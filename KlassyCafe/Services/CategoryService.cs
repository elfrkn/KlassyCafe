using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.Category;
using KlassyCafe.Dtos.Slider;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services
{
    public class CategoryService :ICategoryService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public CategoryService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            await _context.Categories.AddAsync(value);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var values = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var values = await _context.Categories.ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(values);
        }

        public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id)
        {
            var values = await _context.Categories.FindAsync(id);
            return _mapper.Map<GetByIdCategoryDto>(values);
        }

        public int GetCategoryCount()
        {
            return _context.Categories.Count();
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var values = _mapper.Map<Category>(updateCategoryDto);
            _context.Categories.Update(values);
            await _context.SaveChangesAsync();

        }
    }
}
