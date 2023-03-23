namespace BlazorDate.Client.Services.GenderService
{
    public class GenderService : IGenderService
    {
        private readonly HttpClient _httpClient;

        public GenderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Gender> Genders { get ; set ; }

        public async Task GetGenders()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Gender>>>("api/Gender");
            if(response != null && response.Data != null)
                Genders = response.Data;
        }
    }
}
