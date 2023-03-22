using BlazorDate.Shared;

namespace BlazorDate.Server.Services.PersonService
{
    public interface IPersonService
    {
        Task<ServiceResponse<List<Person>>> GetPeopleAsync();

        Task<ServiceResponse<Person>> GetPersonAsync(int personId);
    }
}
