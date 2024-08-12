using KlassyCafe.Dtos.Table;

namespace KlassyCafe.Services
{
    public interface ITableService
    {
        int GetTableByStatusFull();

        public List<ResultTableDto> GetAllTableSignalR();

    }
}
