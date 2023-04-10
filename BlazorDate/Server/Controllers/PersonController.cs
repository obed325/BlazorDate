using BlazorDate.Server.Data;
using BlazorDate.Server.Services.PersonService;
using BlazorDate.Shared;
using BlazorDate.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            this._personService = personService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Person>>> CreatePerson(Person person)
        {
            var result = await _personService.CreatePerson(person);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Person>>> UpdatePerson(Person person)
        {
            var result = await _personService.UpdatePerson(person);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeletePerson(int id)
        {
            var result = await _personService.DeletePerson(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPeopleAsync()
        {
            var result = await _personService.GetPeopleAsync();
            return Ok(result);
        }

        [HttpGet("{personId}")]
        //[Route("{id}")]
        public async Task<ActionResult<ServiceResponse<Person>>> GetPerson(int personId)
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
