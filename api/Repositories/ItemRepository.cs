using api.Data;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _db;

        public ItemRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Item>> GetAllAsync()
        {
            return await _db.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(int id)
        {
            return await _db.Items.FindAsync(id);
        }

        public async Task<Item> AddAsync(Item item)
        {
            _db.Items.Add(item);

            await _db.SaveChangesAsync();
            return item;
        }

        public async Task UpdateAsync(Item item)
        {
            _db.Items.Update(item);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Item item)
        {
            _db.Items.Remove(item);
            await _db.SaveChangesAsync();
        }
    }
}