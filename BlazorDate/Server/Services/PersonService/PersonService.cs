using BlazorDate.Server.Data;
using BlazorDate.Shared;
using BlazorDate.Shared.Models;

namespace BlazorDate.Server.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly DataContext _context;
        public PersonService(DataContext context)
        {
            _context= context;
        }

        public async Task<ServiceResponse<List<Person>>> GetPeopleAsync()
        {
            var response = new ServiceResponse<List<Person>>
            {
                Data = await _context.People.Include(pic=>pic.Pictures.Where(w=>w.IsProfilePicture)).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Person>> GetPersonAsync(int personId)
        {
            var response = new ServiceResponse<Person>();
            var person = await _context.People.FindAsync(personId);
            if(person == null)
            {
                response.Success= false;
                response.Message = "Person not found. ";
            }
            else
            {
                response.Data= person;
            }

            return response;
        }

    }
}
