using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetPerson()
        {
            return Ok(Peoples);
        }

        private static List<Person> Peoples = new List<Person>
        {
            new Person
            {
                PersonId = 1,
                Name = "Börje",
                Nick = "Rattens riddare",
                Description = "Vem är fullast?",
            },
            new Person
            {
                PersonId = 2,
                Name = "Cara",
                Nick = "Carmen",
                Description = "Lugn person med takt och ton, måttfull och balanserad."
            },
            new Person
            {
                PersonId = 3,
                Name = "My",
                Nick = "Lilla My",
                Description = "Liten och dristig."
            },
            new Person
            {
                PersonId = 4,
                Name = "Mumriken",
                Nick = "Snusmumriken",
                Description = "Bär oftast hatt."
            }

        };
    }
}
