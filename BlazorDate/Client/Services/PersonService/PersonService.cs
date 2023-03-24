using BlazorDate.Shared.Models;

namespace BlazorDate.Client.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _httpClient;


        public PersonService(HttpClient httpClient) //List<Person> people
        {
            _httpClient = httpClient;
            //People = people;
        }

        public List<Person> People { get; set; } = new List<Person>();

        public event Action PeopleChanged;

        public async Task<ServiceResponse<Person>> GetPerson(int personId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Person>>($"api/person/{personId}");
            return result;
        }

        public async Task GetPeople(string genderUrl = null)
        {
            var result = genderUrl == null ? 
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Person>>>("api/person") :
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Person>>>($"api/person/gender/{genderUrl}");
            if(result!= null && result.Data!= null)
                People = result.Data;

            PeopleChanged.Invoke();
        }

    }
}
