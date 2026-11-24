
using api.Dtos;

namespace api.Services
{
    public interface ICafeServices
    {
        Task<List<CafeResponseDto>> GetAllAsync();
        Task<CafeResponseDto?> GetByIdAsync(int id);
        Task<CafeResponseDto> CreateAsync(CreateCafeDto dto);

        Task<CafeResponseDto?> UpdateAsync(int id, UpdateCafeDto dto);

        Task<bool> DeleteAsync(int id);
    }
}