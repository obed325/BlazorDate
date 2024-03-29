﻿using BlazorDate.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IGenderService _genderService;
        public GenderController(IGenderService genderService)
        {
            _genderService = genderService; 
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Gender>>>> GetGenders()
        {
            var result = await _genderService.GetGenders();
            return Ok(result);
        }

    }
}
