using KlassyCafe.Dtos.Category;


namespace KlassyCafe.Services
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();

        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);

        Task DeleteCategoryAsync(int id);

        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);

        int GetCategoryCount();
    }
}
