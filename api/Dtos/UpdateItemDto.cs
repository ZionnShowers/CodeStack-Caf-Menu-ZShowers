
namespace api.Dtos
{
    public class UpdateItemDto
    {
        public string Name { get; set;} = string.Empty;
        public int Category_Id { get; set; }
        public int Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Image_Url { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
    }
}