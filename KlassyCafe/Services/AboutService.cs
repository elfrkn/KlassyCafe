using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.About;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services
{
    public class AboutService : IAboutService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public AboutService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAboutAsync(CreateAboutDto createAboutDto)
        {
            var values = _mapper.Map<About>(createAboutDto);
            await _context.Abouts.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAboutAsync(int id)
        {
            var values = await _context.Abouts.FindAsync(id);
            _context.Abouts.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultAboutDto>> GetAllAboutAsync()
        {
            var values = await _context.Abouts.ToListAsync();
            return _mapper.Map<List<ResultAboutDto>>(values);
        }

        public async Task<GetByIdAboutDto> GetByIdAboutAsync(int id)
        {
            var values = await _context.Abouts.FindAsync(id);
            return _mapper.Map<GetByIdAboutDto>(values);
        }

        public async Task UpdateAboutAsync(UpdateAboutDto updateAboutDto)
        {
            var values = _mapper.Map<About>(updateAboutDto);
            _context.Abouts.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
