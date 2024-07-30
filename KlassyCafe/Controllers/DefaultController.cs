using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
