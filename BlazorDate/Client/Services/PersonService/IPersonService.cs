namespace BlazorDate.Client.Services.PersonService
{
    public interface IPersonService
    {
        List<Person> People { get; set; }
        Task GetPeopleAsync();
        Task<ServiceResponse<Person>> GetPerson(int personId);
    }
}
