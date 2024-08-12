using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.Product;
using KlassyCafe.ViewComponents;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services
{
    public class ProductService : IProductService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public ProductService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task ChangeToFalseIsFeature(int id)
        {
            var values = await _context.Products.FindAsync(id);
            values.IsFeature = false;
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task ChangeToTrueIsFeature(int id)
        {
            var values = await _context.Products.FindAsync(id);
            values.IsFeature = true;
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var values = _mapper.Map<Product>(createProductDto);
            await _context.Products.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var values = await _context.Products.FindAsync(id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            var values = await _context.Products.Include(x => x.Category).ToListAsync();
            var list = values.Select(x => new ResultProductWithCategoryDto
            {
                CategoryId = x.CategoryId,
                CategoryName = x.Category.CategoryName,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                IsFeature = x.IsFeature,
                ProductId = x.ProductId,
                Title = x.Title,
                Total = x.Total
            }).ToList();

            return _mapper.Map<List<ResultProductWithCategoryDto>>(list);
        }

        public async Task<GetByIdProductDto> GetByIdProductAsync(int id)
        {
            var values = await _context.Products.FindAsync(id);
            return _mapper.Map<GetByIdProductDto>(values);
        }

        public async Task<List<ResultProductWithCategoryDto>> GetMenuProductListByCategoryAsync(int id)
        {
            var values = await _context.Products.Where(x => x.CategoryId == id).ToListAsync();
            return _mapper.Map<List<ResultProductWithCategoryDto>>(values);
        }

        public int GetProductCount()
        {
            return _context.Products.Count();
        }

        public async Task<List<ResultproductDto>> GetProductIsFeatureTrue()
        {
            var values = await _context.Products.Where(x => x.IsFeature == true).ToListAsync();
            return _mapper.Map<List<ResultproductDto>>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }

       
    }
}
