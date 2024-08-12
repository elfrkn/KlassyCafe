using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.Product;
using System.Linq.Expressions;

namespace KlassyCafe.Services
{
    public interface IProductService
    {
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();

        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task<GetByIdProductDto> GetByIdProductAsync(int id);
        Task ChangeToTrueIsFeature(int id);
        Task ChangeToFalseIsFeature(int id);
        Task<List<ResultproductDto>> GetProductIsFeatureTrue();
        Task<List<ResultProductWithCategoryDto>> GetMenuProductListByCategoryAsync(int id);

        int GetProductCount();

       
    }
}
