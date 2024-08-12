using KlassyCafe.Dtos.About;

namespace KlassyCafe.Services
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAboutAsync();

        Task CreateAboutAsync(CreateAboutDto createAboutDto);
        Task UpdateAboutAsync(UpdateAboutDto updateAboutDto);

        Task DeleteAboutAsync(int id);

        Task<GetByIdAboutDto> GetByIdAboutAsync(int id);
    }
}
