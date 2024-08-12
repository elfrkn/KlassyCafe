using KlassyCafe.Services;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _FeaturesComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _FeaturesComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetProductIsFeatureTrue();
            return View(values);
        }
    }
}
