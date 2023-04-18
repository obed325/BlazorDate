using static System.Net.WebRequestMethods;

namespace BlazorDate.Client.Services.SeriousnessService
{
    public class SeriousnessService : ISeriousnessService
    {
        private readonly HttpClient _httpClient;
        public SeriousnessService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Seriousness> Seriousnesses { get; set; } = new List<Seriousness>();

        public event Action OnChange;

        public async Task AddSeriousness(Seriousness seriousness)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Seriousness/admin", seriousness);
            Seriousnesses = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Seriousness>>>()).Data;
            await GetSeriousnesses();
            OnChange.Invoke();
        }

        public Seriousness CreateNewSeriousness()
        {
            Seriousness newSeriousness = new Seriousness { IsNew = true, Editing = true };
            Seriousnesses.Add(newSeriousness);
            OnChange.Invoke();
            return newSeriousness;
        }

        public async Task DeleteSeriousness(int seriousnessId)
        {
            var response = await _httpClient.DeleteAsync($"api/Seriousness/admin/{seriousnessId}");
            Seriousnesses = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Seriousness>>>()).Data;
            await GetSeriousnesses();
            OnChange.Invoke();
        }

        public async Task GetSeriousnesses()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Seriousness>>>("api/Seriousnes");
            if (response != null && response.Data != null)
                Seriousnesses = response.Data;
        }

        public async Task UpdateSeriousness(Seriousness seriousness)
        {
                var response = await _httpClient.PutAsJsonAsync("api/seriousness/admin", seriousness);
                Seriousnesses = (await response.Content
                    .ReadFromJsonAsync<ServiceResponse<List<Seriousness>>>()).Data;
                await GetSeriousnesses();
                OnChange.Invoke();
        }
    }
}
