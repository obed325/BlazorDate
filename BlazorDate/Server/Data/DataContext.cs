using BlazorDate.Shared.Models;

namespace BlazorDate.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Gender>().HasData(
                new Gender
                {
                    Id = 1,
                    Name = "Female",
                    Description = "Så kallad cis-kvinna, som tänder främst på män.",
                    Url = "fem"
                },
                new Gender
                {
                    Id = 2,
                    Name = "Man",
                    Description = "Identifirar sig främst som sitt biologiska kön och attraheras av sk mottsatta könet. Även så kallat Cis-man.",
                    Url = "men"
                }
            );

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    PersonId = 1,
                    Name = "Börje",
                    Nick = "Rattens riddare",
                    Description = "Vem är fullast?",
                    GenderId = 2
                },
                new Person
                {
                    PersonId = 2,
                    Name = "Cara",
                    Nick = "Carmen",
                    Description = "Lugn person med takt och ton, måttfull och balanserad.",
                    GenderId = 1
                },
                new Person
                {
                    PersonId = 3,
                    Name = "My",
                    Nick = "Lilla My",
                    Description = "Liten och dristig.",
                    GenderId = 1
                },
                new Person
                {
                    PersonId = 4,
                    Name = "Mumriken",
                    Nick = "Snusmumriken",
                    Description = "Bär oftast hatt.",
                    GenderId = 2
                }
            );
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonPreference> PersonPreferences { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Seriousness> Seriousnesses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }

    }
}
