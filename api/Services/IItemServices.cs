
using api.Dtos;

namespace api.Services
{
    public interface IItemServices
    {
        Task<List<ItemResponseDto>> GetAllAsync();
        Task<ItemResponseDto?> GetByIdAsync(int id);
        Task<ItemResponseDto> CreateAsync(CreateItemDto dto);

        Task<ItemResponseDto?> UpdateAsync(int id, UpdateItemDto dto);

        Task<bool> DeleteAsync(int id);
    }
}