using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.Dtos.Category;
using KlassyCafe.Dtos.Rezervation;
using KlassyCafe.Dtos.Table;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services
{
    public class TableService : ITableService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public TableService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ResultTableDto> GetAllTableSignalR()
        {
            var values = _context.Tables.ToList();
            return _mapper.Map<List<ResultTableDto>>(values);
        }

        public int GetTableByStatusFull()
        {
            return _context.Tables.Where(x => x.IsEmpty == false).Count();
        }
    }
}
