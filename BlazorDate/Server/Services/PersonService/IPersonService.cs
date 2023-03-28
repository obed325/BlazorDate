using BlazorDate.Shared;

namespace BlazorDate.Server.Services.PersonService
{
    public interface IPersonService
    {
        Task<ServiceResponse<List<Person>>> GetPeopleAsync();

        Task<ServiceResponse<Person>> GetPersonAsync(int personId);

        Task<ServiceResponse<List<Person>>> GetPeopleByGender(string genderId);
        Task<ServiceResponse<Person>> CreatePerson(Person person);
        Task<ServiceResponse<Person>> UpdatePerson(Person person);
        Task<ServiceResponse<bool>> DeletePerson(int personId);
    }
}
