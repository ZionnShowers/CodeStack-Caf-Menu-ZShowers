
namespace api.Dtos
{
    public class CreateCafeDto
    {
        public string Name { get; set;} = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Hours { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}