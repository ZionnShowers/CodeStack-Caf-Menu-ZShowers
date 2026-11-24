
using api.Dtos;
using api.Models;
using api.Repositories;

namespace api.Services
{
    public class ItemServices : IItemServices
    {

        private readonly IItemRepository _repository;

        public ItemServices(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ItemResponseDto> CreateAsync(CreateItemDto dto)
        {
            Item item = new Item();
            item.Name = dto.Name;
            item.Category_Id = dto.Category_Id;
            item.Price = dto.Price;
            item.Description = dto.Description;
            item.Image_Url = dto.Image_Url;
            item.Tag = dto.Tag;

            Item saved = await _repository.AddAsync(item);

            return ToDto(saved);
        }


        public async Task<List<ItemResponseDto>> GetAllAsync()
        {

            List<Item> items = await _repository.GetAllAsync();

            return items.Select(ToDto).ToList();
        }

        public async Task<ItemResponseDto?> GetByIdAsync(int id)
        {
            Item? item = await _repository.GetByIdAsync(id);
            if(item is null)
            {
                return null;
            }
            return ToDto(item);
        }


        private static ItemResponseDto ToDto(Item item)
        {
            return new ItemResponseDto
            {
                Id = item.Id,
                Name = item.Name,
                Category_Id = item.Category_Id,
                Price = item.Price,
                Description = item.Description,
                Image_Url = item.Image_Url,
                Tag = item.Tag
            };
        }

        public async Task<ItemResponseDto?> UpdateAsync(int id, UpdateItemDto dto)
        {
            Item? item = await _repository.GetByIdAsync(id);

            if(item is null)
            {
                return null;
            }

            item.Name = dto.Name;
            item.Category_Id = dto.Category_Id;
            item.Price = dto.Price;
            item.Description = dto.Description;
            item.Image_Url = dto.Image_Url;
            item.Tag = dto.Tag;


            await _repository.UpdateAsync(item);

            return ToDto(item);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Item? item = await _repository.GetByIdAsync(id);

            if(item is null)
            {
                return false;
            }

            await _repository.DeleteAsync(item);
            return true;
        }
    }
}