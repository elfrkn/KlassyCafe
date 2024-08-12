using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.Rezervation;
using KlassyCafe.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace KlassyCafe.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IProductService _productService;
        private readonly KlassyContext _context;


        public DefaultController(IProductService productService, KlassyContext context)
        {
            _productService = productService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<PartialViewResult> GetProductListByCategory(int id)
        {
            var values = await _productService.GetMenuProductListByCategoryAsync(id);
            return PartialView(values);
        }


        [HttpPost]
        public IActionResult CreateRezervation(Rezervation rezervation)
        {
            if (ModelState.IsValid)
            {
                _context.Rezervations.Add(rezervation);
                _context.SaveChanges();
                JsonConvert.SerializeObject(rezervation);
                return NoContent();
            }
            else
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors)
                    .Select(y => y.ErrorMessage)
                    .ToList();
                return BadRequest(new { errors });
            }
        }
    }
}
