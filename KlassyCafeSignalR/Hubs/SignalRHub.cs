using KlassyCafe.DAL.Context;
using KlassyCafe.Services;
using Microsoft.AspNetCore.SignalR;

namespace KlassyCafeSignalR.Hubs
{

    //Sunucu görevi görüyor.Uygulamamızın server kısmı
    public class SignalRHub :Hub
    {
        private readonly IRezervationService _rezervationService;
        private readonly ICategoryService _categoryService;
        private readonly ITableService _tableService;
        private readonly IProductService _productService;

        public SignalRHub(IRezervationService rezervationService, ICategoryService categoryService, ITableService tableService, IProductService productService)
        {
            _rezervationService = rezervationService;
            _categoryService = categoryService;
            _tableService = tableService;
            _productService = productService;
        }

        public async Task SendStatistic()
        {
            var valueRez = _rezervationService.GetRezervationCount();
            await Clients.All.SendAsync("RezervationCount", valueRez);

            var valueCtgry = _categoryService.GetCategoryCount();
            await Clients.All.SendAsync("CategoryCount", valueCtgry);

            var valueTable = _tableService.GetTableByStatusFull();
            await Clients.All.SendAsync("TableFullCount", valueTable);

            var valueProduct = _productService.GetProductCount();
            await Clients.All.SendAsync("ProductCount", valueProduct);

           

        }

        public async Task GetRezervationList()
        {
            var value = _rezervationService.GetListAllSignalR();
            await Clients.All.SendAsync("RezervationList", value);

        }

        public async Task GetTableStatus()
        {
            var value = _tableService.GetAllTableSignalR();
            await Clients.All.SendAsync("TableStatus", value);
        }

       
    }
}
