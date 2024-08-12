using KlassyCafe.Dtos.Slider;

namespace KlassyCafe.Services
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();

        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);

        Task DeleteSliderAsync(int id);
        Task<GetByIdSliderDto> GetByIdSliderAsync(int id);
        Task ChangeToTrueByImage(int id);
        Task ChangeToFalseByImage(int id);
        Task<List<ResultSliderDto>> GetAllSliderStatusIsTrue();
       

    }
}
