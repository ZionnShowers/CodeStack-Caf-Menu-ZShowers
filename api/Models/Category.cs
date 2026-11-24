
namespace api.Models
{
    public class Category : BaseEntity
    {
        // string.Empty gives a starting value, so the text is never null.
        public string Name { get; set;} = string.Empty;
    }
}