namespace BlazorDate.Client.Services.PersonService
{
    public interface IPersonService
    {
        event Action PeopleChanged;
        List<Person> People { get; set; }
        Task GetPeople(string genderUrl = null);
        Task<ServiceResponse<Person>> GetPerson(int personId);
    }
}
