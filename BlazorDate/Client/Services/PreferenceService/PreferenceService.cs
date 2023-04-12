using static System.Net.WebRequestMethods;

namespace BlazorDate.Client.Services.PreferenceService
{
    public class PreferenceService : IPreferenceService
    {
        private readonly HttpClient _http;

        public PreferenceService(HttpClient http)
        {
            _http = http;
        }

        public List<Preference> Preferences { get; set; } = new List<Preference>();
        public event Action OnChange;

        public async Task AddPreference(Preference preference)
        {
            var response = await _http.PostAsJsonAsync("api/Preference/admin", preference);
            Preferences = (await response.Content
                    .ReadFromJsonAsync<ServiceResponse<List<Preference>>>()).Data;
            await GetPreferences();
            OnChange.Invoke();
        }

        public Preference CreateNewPreference()
        {
            var newPreference = new Preference { IsNew = true, Editing = true };
            Preferences.Add(newPreference);
            OnChange.Invoke();
            return newPreference;
        }

        public async Task DeletePreference(int preferenceId)
        {
            var response = await _http.DeleteAsync($"api/Preference/admin/{preferenceId}");
            Preferences = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Preference>>>()).Data;
            await GetPreferences();
            OnChange.Invoke();
        }

        public async Task GetPreferences()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Preference>>>("api/Preference");
            if (response != null && response.Data != null)
                Preferences = response.Data;
        }

        public async Task UpdatePreference(Preference preference)
        {
            var response = await _http.PutAsJsonAsync("api/preference/admin", preference);
            Preferences = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Preference>>>()).Data;
            await GetPreferences();
            OnChange.Invoke();
        }
    }
}
