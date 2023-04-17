namespace BlazorDate.Server.Services.PreferenceService
{
    public class PreferenceService : IPreferenceService
    {
        private readonly DataContext _context;

        public PreferenceService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Preference>>> AddPreference(Preference preference)
        {
            preference.Editing = preference.IsNew = false;
            _context.Preferences.Add(preference);
            await _context.SaveChangesAsync();
            return await GetPreferences();
        }

        public async Task<ServiceResponse<List<Preference>>> DeletePreference(int id)
        {
            var dBpreference = await GetPreferenceById(id);
            if (dBpreference == null)
            {
                return new ServiceResponse<List<Preference>>
                {
                    Success = false,
                    Message = "Preference not found."
                };
            }
            _context.Preferences.Remove(dBpreference);
            await _context.SaveChangesAsync();

            return await GetPreferences();
        }

        private async Task<Preference> GetPreferenceById(int id)
        {
            return await _context.Preferences.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<ServiceResponse<List<Preference>>> GetPreferences()
        {
            var dBpreferences = await _context.Preferences.ToListAsync();
            return new ServiceResponse<List<Preference>>
            {
                Data = dBpreferences
            };
        }

        public async Task<ServiceResponse<List<Preference>>> UpdatePreference(Preference preference)
        {
            var dbPreference = await GetPreferenceById(preference.Id);
            if (dbPreference == null)
            {
                return new ServiceResponse<List<Preference>>
                { 
                    Success = false, 
                    Message = "Preference not found." 
                };
            }
            dbPreference.Name = preference.Name;
            dbPreference.Description = preference.Description;
            dbPreference.Category = preference.Category;

            await _context.SaveChangesAsync();

            return await GetPreferences();
        }
    }
}
