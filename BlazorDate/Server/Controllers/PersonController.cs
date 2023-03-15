using BlazorDate.Server.Data;
using BlazorDate.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly DataContext _context;
        public PersonController(DataContext dataContext)
        {
            this._context = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPerson()
        {
            var persons = await _context.Persons.ToListAsync();
            var response = new ServiceResponse<List<Person>>()
            {
                Data = persons
            };
            return Ok(persons);
        }

     
    }
}
