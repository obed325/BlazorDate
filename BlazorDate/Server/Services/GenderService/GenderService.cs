using BlazorDate.Shared;
using BlazorDate.Server.Data;

namespace BlazorDate.Server.Services.GenderService
{
    public class GenderService : IGenderService
    {
        private readonly DataContext _context;

        public GenderService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Gender>>> GetGenders()
        {
            var genders = await _context.Genders.ToListAsync();
            return new ServiceResponse<List<Gender>>
            {
                Data = genders,
            };
        }
    }
}
