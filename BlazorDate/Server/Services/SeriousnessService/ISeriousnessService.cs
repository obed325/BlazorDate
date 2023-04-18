namespace BlazorDate.Server.Services.SeriousnessService
{
    public interface ISeriousnessService
    {
        Task<ServiceResponse<List<Seriousness>>> GetSeriousnesses();
        Task<ServiceResponse<List<Seriousness>>> AddSeriousness(Seriousness Seriousness);
        Task<ServiceResponse<List<Seriousness>>> UpdateSeriousness(Seriousness Seriousness);
        Task<ServiceResponse<List<Seriousness>>> DeleteSeriousness(int id);
    }
}
