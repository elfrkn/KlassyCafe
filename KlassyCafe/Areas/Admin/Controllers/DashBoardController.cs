using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
