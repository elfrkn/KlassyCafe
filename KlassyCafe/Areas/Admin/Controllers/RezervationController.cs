using KlassyCafe.Dtos.Rezervation;
using KlassyCafe.Services;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RezervationController : Controller
    {
        private readonly IRezervationService _rezervationService;

        public RezervationController(IRezervationService rezervationService)
        {
            _rezervationService = rezervationService;
        }

        public async Task<IActionResult> RezervationList()
        {
            var values = await _rezervationService.GetAllRezervationAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateRezervation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRezervation(CreateRezervationDto createRezervationDto)
        {
            await _rezervationService.CreateRezervationAsync(createRezervationDto);
            return RedirectToAction("RezervationList");
        }

        public async Task<IActionResult> DeleteRezervation(int id)
        {
            await _rezervationService.DeleteRezervationAsync(id);
            return RedirectToAction("RezervationList");

        }

        [HttpGet]
        public async Task<IActionResult> UpdateRezervation(int id)
        {
            var values = await _rezervationService.GetByIdRezervationAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRezervation(UpdateRezervationDto updateRezervationDto)
        {
            await _rezervationService.UpdateRezervationAsync(updateRezervationDto);
            return RedirectToAction("RezervationList");
        }
    }
}
