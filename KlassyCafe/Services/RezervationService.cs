using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.Rezervation;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services
{
    public class RezervationService :IRezervationService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public RezervationService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateRezervationAsync(CreateRezervationDto createRezervationDto)
        {
            var value = _mapper.Map<Rezervation>(createRezervationDto);
            await _context.Rezervations.AddAsync(value);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRezervationAsync(int id)
        {
            var values = await _context.Rezervations.FindAsync(id);
            _context.Rezervations.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultRezervationDto>> GetAllRezervationAsync()
        {
            var values = await _context.Rezervations.ToListAsync();
            return _mapper.Map<List<ResultRezervationDto>>(values);
        }

        public async Task<GetByIdRezervationDto> GetByIdRezervationAsync(int id)
        {
            var values = await _context.Rezervations.FindAsync(id);
            return _mapper.Map<GetByIdRezervationDto>(values);
        }

        public List<ResultRezervationDto> GetListAllSignalR()
        {
            var values = _context.Rezervations.ToList();
            return _mapper.Map<List<ResultRezervationDto>>(values);
           
        }

        public int GetRezervationCount()
        {
            return _context.Rezervations.Count();
        }

        public async Task UpdateRezervationAsync(UpdateRezervationDto updateRezervationDto)
        {
            var values = _mapper.Map<Rezervation>(updateRezervationDto);
            _context.Rezervations.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
