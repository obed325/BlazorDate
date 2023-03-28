using BlazorDate.Server.Data;
using BlazorDate.Shared;
using BlazorDate.Shared.Models;

namespace BlazorDate.Server.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly DataContext _context;
        private readonly IGenderService _genderService;
        public PersonService(DataContext context, IGenderService genderService)
        {
            _context = context;
            _genderService = genderService;
        }

        public async Task<ServiceResponse<Person>> CreatePerson(Person person)
        {
                _context.People.Add(person);
            await _context.SaveChangesAsync();
            return new ServiceResponse<Person> { Data = person };
        }

        public async Task<ServiceResponse<bool>> DeletePerson(int personId)
        {
            var dbPerson = await _context.People.FindAsync(personId);
            if (dbPerson == null)
            {
                return new ServiceResponse<bool>
                {
                    Success = false,
                    Data = false,
                    Message = "Person not found."
                };
            }

            //dbPerson.Deleted = true;
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true };
        }

        public async Task<ServiceResponse<List<Person>>> GetPeopleAsync()
        {
            var response = new ServiceResponse<List<Person>>
            {
                Data = await _context.People.Include(pic => pic.Pictures.Where(w => w.IsProfilePicture)).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Person>>> GetPeopleByGender(string genderUrl)
        {
            var response = new ServiceResponse<List<Person>>
            {
                Data = await _context.People
                    .Where(p => p.Gender.Url.ToLower().Equals(genderUrl.ToLower()))
                    .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Person>> GetPersonAsync(int personId)
        {
            var response = new ServiceResponse<Person>();
            var person = await _context.People.FindAsync(personId);
            if (person == null)
            {
                response.Success = false;
                response.Message = "Person not found. ";
            }
            else
            {
                response.Data = person;
            }

            return response;
        }

        public async Task<ServiceResponse<Person>> UpdatePerson(Person person)
        {
            var dbPerson = await _context.People.FindAsync(person.PersonId);
            if (dbPerson == null)
            {
                return new ServiceResponse<Person>
                {
                    Success = false,
                    Message = "Person not found."
                };
            }
            dbPerson.Name = person.Name;
            dbPerson.Gender = person.Gender;
            dbPerson.Nick = person.Nick;
            dbPerson.DateOfBirth = person.DateOfBirth;
            dbPerson.Description = person.Description;
            dbPerson.Preferences = person.Preferences;
            dbPerson.ProfileText = person.ProfileText;
            dbPerson.Pictures = person.Pictures;
            dbPerson.Updated = DateTime.Now;

            await _context.SaveChangesAsync();
            return new ServiceResponse<Person> { Data = person };
        }
    }
}
