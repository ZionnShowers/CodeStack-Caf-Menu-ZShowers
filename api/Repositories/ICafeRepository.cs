
using api.Models;

namespace api.Repositories
{
    public interface ICafeRepository
    {
        Task<List<Cafe>> GetAllAsync();
        Task<Cafe?> GetByIdAsync(int id);
        Task<Cafe> AddAsync(Cafe cafe);

        Task UpdateAsync(Cafe cafe);

        Task DeleteAsync(Cafe cafe);
    }
}