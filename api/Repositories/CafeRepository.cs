using api.Data;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class CafeRepository : ICafeRepository
    {
        private readonly AppDbContext _db;

        public CafeRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Cafe>> GetAllAsync()
        {
            return await _db.Cafes.ToListAsync();
        }

        public async Task<Cafe?> GetByIdAsync(int id)
        {
            return await _db.Cafes.FindAsync(id);
        }

        public async Task<Cafe> AddAsync(Cafe cafe)
        {
            _db.Cafes.Add(cafe);

            await _db.SaveChangesAsync();
            return cafe;
        }

        public async Task UpdateAsync(Cafe cafe)
        {
            _db.Cafes.Update(cafe);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Cafe cafe)
        {
            _db.Cafes.Remove(cafe);
            await _db.SaveChangesAsync();
        }
    }
}