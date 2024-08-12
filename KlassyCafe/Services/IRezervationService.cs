using KlassyCafe.Dtos.Rezervation;

namespace KlassyCafe.Services
{
    public interface IRezervationService
    {
        Task<List<ResultRezervationDto>> GetAllRezervationAsync();

        Task CreateRezervationAsync(CreateRezervationDto createRezervationDto);
        Task UpdateRezervationAsync(UpdateRezervationDto updateRezervationDto);
        Task DeleteRezervationAsync(int id);
        Task<GetByIdRezervationDto> GetByIdRezervationAsync(int id);
        int GetRezervationCount();
        public List<ResultRezervationDto> GetListAllSignalR();
    }
}