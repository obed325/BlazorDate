using BlazorDate.Server.Data;
using BlazorDate.Server.Services.PersonService;
using BlazorDate.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            this._personService = personService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPeopleAsync()
        {
            var result = await _personService.GetPeopleAsync();
            return Ok(result);
        }

        [HttpGet("{personId}")]
        //[Route("{id}")]
        public async Task<ActionResult<ServiceResponse<Person>>> GetProduct(int personId)
        {
            var result = await _personService.GetPersonAsync(personId);
            return Ok(result);
        }

        [HttpGet("gender/{genderUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPeopleByGender(string genderUrl)
        {
            var result = await _personService.GetPeopleByGender(genderUrl);
            return Ok(result);
        }
    }
}
