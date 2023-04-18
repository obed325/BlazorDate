using BlazorDate.Server.Services.PreferenceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreferenceController : ControllerBase
    {
        private readonly IPreferenceService _preferenceService;

        public PreferenceController(IPreferenceService preferenceService)
        {
            _preferenceService = preferenceService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Preference>>>> GetPreferences()
        {
            var result = await _preferenceService.GetPreferences();
            return Ok(result);
        }

        //todo admin area
        [HttpDelete("admin/{id}")]
        public async Task<ActionResult<ServiceResponse<List<Preference>>>> DeletePreference(int id)
        {
            var result = await _preferenceService.DeletePreference(id);
            return Ok(result);
        }

        [HttpPost("admin")]
        public async Task<ActionResult<ServiceResponse<List<Preference>>>> AddPreference(Preference preference)
        {
            var result = await _preferenceService.AddPreference(preference);
            return Ok(result);
        }

        [HttpPut("admin")]
        public async Task<ActionResult<ServiceResponse<List<Preference>>>> UpdatePreference(Preference preference)
        {
            var result = await _preferenceService.UpdatePreference(preference);
            return Ok(result);
        }
    }
}
