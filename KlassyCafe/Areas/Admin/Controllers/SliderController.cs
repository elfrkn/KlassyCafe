
using KlassyCafe.Dtos.Slider;
using KlassyCafe.Services;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> SliderList()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            await _sliderService.CreateSliderAsync(createSliderDto);
            return RedirectToAction("SliderList");
        }

        public async Task<IActionResult> DeleteSlider(int id)
        {
             await _sliderService.DeleteSliderAsync(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSlider(int id)
        {
            var values = await _sliderService.GetByIdSliderAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.UpdateSliderAsync(updateSliderDto);
            return RedirectToAction("SliderList");
        }

        public async Task<IActionResult> ChangeToFalseStatus(int id)
        {
            await _sliderService.ChangeToFalseByImage(id);
            return RedirectToAction("SliderList");
        }

        public async Task<IActionResult> ChangeToTrueStatus(int id)
        {
            await _sliderService.ChangeToTrueByImage(id);
            return RedirectToAction("SliderList");
        }
    }
}
