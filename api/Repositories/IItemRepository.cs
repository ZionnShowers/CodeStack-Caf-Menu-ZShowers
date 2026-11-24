
using api.Models;

namespace api.Repositories
{
    public interface IItemRepository
    {
        Task<List<Item>> GetAllAsync();
        Task<Item?> GetByIdAsync(int id);
        Task<Item> AddAsync(Item item);

        Task UpdateAsync(Item item);

        Task DeleteAsync(Item item);
    }
}