//the base entity: the columns Every table shares, so we only write them once.
using System.Security.Cryptography.X509Certificates;

namespace api.Models
{
    public class BaseEntity
    {
        //EF Core treats a property named Id as the primary Key.
        //The DB gfills it in for use when a new row is saved / created.
        public int Id { get; set;}
        // //DateTime.UtcNow is the current in UTC, so every server agrees on the time.
        // public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}