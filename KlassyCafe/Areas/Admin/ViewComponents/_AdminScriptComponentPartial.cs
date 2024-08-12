using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Areas.Admin.ViewComponents
{
    public class _AdminScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
