using KlassyCafe.Services;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TableController : Controller
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        public IActionResult TableList()
        {
            var values = _tableService.GetAllTableSignalR();
            return View(values);
        }
    }
}
