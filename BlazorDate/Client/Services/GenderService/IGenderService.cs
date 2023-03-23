namespace BlazorDate.Client.Services.GenderService
{
    public interface IGenderService
    {
         List<Gender> Genders { get; set; }
        Task GetGenders();
    }
}
