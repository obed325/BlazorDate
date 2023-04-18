namespace BlazorDate.Client.Services.SeriousnessService
{
    public interface ISeriousnessService
    {
        event Action OnChange;
        List<Seriousness> Seriousnesses { get; set; }
        Task GetSeriousnesses();
        Task AddSeriousness(Seriousness seriousness);
        Task UpdateSeriousness(Seriousness seriousness);
        Task DeleteSeriousness(int seriousnessId);
        Seriousness CreateNewSeriousness();
    }
}
