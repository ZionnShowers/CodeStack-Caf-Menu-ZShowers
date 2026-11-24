using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    // The DbContext is Ef Core's connection to the database
    //Our Repositores use it to read and save rows. (Data to our Database)
    public class AppDbContext : DbContext
    {
        //The options (which database to use, and its connection string) come from
        //Program.cs, through dependency injection. We just hand them to the DbContext
        //Base class
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Each DbSet is one table. This one becomes the Movies table.
        public DbSet<Cafe> Cafes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}