
namespace api.Models
{
    public class Cafe : BaseEntity
    {
        // string.Empty gives a starting value, so the text is never null.
        public string Name { get; set;} = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Hours { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}