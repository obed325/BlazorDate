using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BlazorDate.Server.Services.SeriousnessService;


namespace BlazorDate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriousnessController : ControllerBase
    {
        private readonly ISeriousnessService _seriousnessService;
        public SeriousnessController(ISeriousnessService seriousnessService)
        {
            _seriousnessService = seriousnessService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Seriousness>>>> GetSeriousnesses()
        {
            var result = await _seriousnessService.GetSeriousnesses();
            return Ok(result);
        }

        [HttpDelete("admin/{id}")]
        public async Task<ActionResult<ServiceResponse<List<Seriousness>>>> deleteSeriousness(int id)
        {
            var result = await _seriousnessService.DeleteSeriousness(id);
            return Ok(result);
        }

        [HttpPost("admin")]
        public async Task<ActionResult<ServiceResponse<List<Seriousness>>>> AddSeriousness(Seriousness seriousness)
        {
            var result = await _seriousnessService.AddSeriousness(seriousness);
            return Ok(result);
        }

        [HttpPut("admin")]
        public async Task<ActionResult<ServiceResponse<List<Seriousness>>>> UpdateSeriousness(Seriousness seriousness)
        {
            var result = await _seriousnessService.UpdateSeriousness(seriousness);
            return Ok(result);
        }
    }
}
