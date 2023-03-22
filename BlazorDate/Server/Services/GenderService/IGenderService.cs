using BlazorDate.Shared;

namespace BlazorDate.Server.Services.GenderService
{
    public interface IGenderService
    {
        Task<ServiceResponse<List<Gender>>> GetGenders();
    }
}
