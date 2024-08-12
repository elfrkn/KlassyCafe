using KlassyCafe.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafeSignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervationsController : ControllerBase
    {
        private readonly IRezervationService _rezervationService;

        public RezervationsController(IRezervationService rezervationService)
        {
            _rezervationService = rezervationService;
        }

        [HttpGet]
        public async Task<IActionResult> RezervationList()
        {
            var values = await  _rezervationService.GetAllRezervationAsync();
            return Ok(values);
        }

        [HttpGet("GetRezervationCount")]

        public IActionResult GetRezervationCount()
        {
            var value = _rezervationService.GetRezervationCount();
            return Ok(value);
        }
    }
}
