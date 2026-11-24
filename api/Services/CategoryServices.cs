
using api.Dtos;
using api.Models;
using api.Repositories;

namespace api.Services
{
    public class CategoryServices : ICategoryServices
    {

        private readonly ICategoryRepository _repository;

        public CategoryServices(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<CategoryResponseDto> CreateAsync(CreateCategoryDto dto)
        {
            Category category = new Category();
            category.Name = dto.Name;

            Category saved = await _repository.AddAsync(category);

            return ToDto(saved);
        }


        public async Task<List<CategoryResponseDto>> GetAllAsync()
        {

            List<Category> categories = await _repository.GetAllAsync();

            return categories.Select(ToDto).ToList();
        }

        public async Task<CategoryResponseDto?> GetByIdAsync(int id)
        {
            Category? category = await _repository.GetByIdAsync(id);
            if(category is null)
            {
                return null;
            }
            return ToDto(category);
        }


        private static CategoryResponseDto ToDto(Category category)
        {
            return new CategoryResponseDto
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        public async Task<CategoryResponseDto?> UpdateAsync(int id, UpdateCategoryDto dto)
        {
            Category? category = await _repository.GetByIdAsync(id);

            if(category is null)
            {
                return null;
            }

            category.Name = dto.Name;


            await _repository.UpdateAsync(category);

            return ToDto(category);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Category? category = await _repository.GetByIdAsync(id);

            if(category is null)
            {
                return false;
            }

            await _repository.DeleteAsync(category);
            return true;
        }
    }
}