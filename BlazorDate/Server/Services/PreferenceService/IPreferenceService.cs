namespace BlazorDate.Server.Services.PreferenceService
{
    public interface IPreferenceService
    {
        Task <ServiceResponse<List<Preference>>> GetPreferences();
        Task<ServiceResponse<List<Preference>>> AddPreference(Preference preference);
        Task<ServiceResponse<List<Preference>>> UpdatePreference(Preference preference);
        Task<ServiceResponse<List<Preference>>> DeletePreference(int id);
    }
}
