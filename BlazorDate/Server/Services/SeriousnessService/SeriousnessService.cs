using BlazorDate.Shared.Models;

namespace BlazorDate.Server.Services.SeriousnessService
{
    public class SeriousnessService : ISeriousnessService
    {
        private readonly DataContext _context;
        public SeriousnessService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Seriousness>>> AddSeriousness(Seriousness seriousness)
        {
            seriousness.Editing = seriousness.IsNew = false;
            _context.Seriousnesses.Add(seriousness);
            await _context.SaveChangesAsync();
            return await GetSeriousnesses();
        }

        public async Task<ServiceResponse<List<Seriousness>>> DeleteSeriousness(int id)
        {
            var dBseriousness = await GetSeriousnessById(id);
            if (dBseriousness == null)
            {
                return new ServiceResponse<List<Seriousness>>
                {
                    Success = false,
                    Message = "Preference not found."
                };
            }
            _context.Seriousnesses.Remove(dBseriousness);
            await _context.SaveChangesAsync();

            return await GetSeriousnesses();
        }

        private async Task<Seriousness> GetSeriousnessById(int id)
        {
            return await _context.Seriousnesses.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ServiceResponse<List<Seriousness>>> GetSeriousnesses()
        {
            var dBseriousnesses = await _context.Seriousnesses.ToListAsync();
            return new ServiceResponse<List<Seriousness>>
            {
                Data = dBseriousnesses
            };
        }

        public async Task<ServiceResponse<List<Seriousness>>> UpdateSeriousness(Seriousness seriousness)
        {
            var dBseriousness = await GetSeriousnessById(seriousness.Id);
            if (dBseriousness == null)
            {
                return new ServiceResponse<List<Seriousness>>
                {
                    Success = false,
                    Message = "Not found."
                };
            }
            dBseriousness.Level = seriousness.Level;

            await _context.SaveChangesAsync();

            return await GetSeriousnesses();
        }
    }
}
