using KlassyCafe.Dtos.Product;
using KlassyCafe.Services;
using Microsoft.AspNetCore.Mvc;
using X.PagedList.Extensions;

namespace KlassyCafe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> ProductList(int page=1, int pageSize=5)
        {
            var values = await _productService.GetAllProductWithCategoryAsync();
            return View(values.ToPagedList(page,pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            ViewBag.Category = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var category = await _categoryService.GetAllCategoryAsync();
            ViewBag.Category = category;

            var values = await _productService.GetByIdProductAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> ChangeToFalseIsFeature(int id)
        {
            await _productService.ChangeToFalseIsFeature(id);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> ChangeToTrueIsFeature(int id)
        {
            await _productService.ChangeToTrueIsFeature(id);
            return RedirectToAction("ProductList");
        }
    }
}
