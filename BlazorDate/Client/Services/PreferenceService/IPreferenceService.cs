namespace BlazorDate.Client.Services.PreferenceService
{
    public interface IPreferenceService
    {
        event Action OnChange;
        List<Preference> Preferences { get; set; }
        Task GetPreferences();
        Task AddPreference(Preference preference);
        Task UpdatePreference(Preference preference);
        Task DeletePreference(int preferenceId);
        Preference CreateNewPreference();
    }
}
