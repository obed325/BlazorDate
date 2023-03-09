using DateBlazor.Shared.Models;

namespace BlazorDate.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonPreference> PersonPreferences { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Profile> profiles { get; set; }
        public DbSet<Seriousness> Seriousnesses { get; set; }

    }
}
