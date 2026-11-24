
using api.Dtos;
using api.Models;
using api.Repositories;

namespace api.Services
{
    public class CafeServices : ICafeServices
    {

        private readonly ICafeRepository _repository;

        public CafeServices(ICafeRepository repository)
        {
            _repository = repository;
        }

        public async Task<CafeResponseDto> CreateAsync(CreateCafeDto dto)
        {
            Cafe cafe = new Cafe();
            cafe.Name = dto.Name;
            cafe.Tagline = dto.Tagline;
            cafe.Address = dto.Address;
            cafe.Hours = dto.Hours;
            cafe.Phone = dto.Phone;

            Cafe saved = await _repository.AddAsync(cafe);

            return ToDto(saved);
        }


        public async Task<List<CafeResponseDto>> GetAllAsync()
        {

            List<Cafe> cafes = await _repository.GetAllAsync();

            return cafes.Select(ToDto).ToList();
        }

        public async Task<CafeResponseDto?> GetByIdAsync(int id)
        {
            Cafe? cafe = await _repository.GetByIdAsync(id);
            if(cafe is null)
            {
                return null;
            }
            return ToDto(cafe);
        }


        private static CafeResponseDto ToDto(Cafe cafe)
        {
            return new CafeResponseDto
            {
                Id = cafe.Id,
                Name = cafe.Name,
                Tagline = cafe.Tagline,
                Address = cafe.Address,
                Hours = cafe.Hours,
                Phone = cafe.Phone
            };
        }

        public async Task<CafeResponseDto?> UpdateAsync(int id, UpdateCafeDto dto)
        {
            Cafe? cafe = await _repository.GetByIdAsync(id);

            if(cafe is null)
            {
                return null;
            }

            cafe.Name = dto.Name;
            cafe.Tagline = dto.Tagline;
            cafe.Address = dto.Address;
            cafe.Hours = dto.Hours;
            cafe.Phone = dto.Phone;


            await _repository.UpdateAsync(cafe);

            return ToDto(cafe);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Cafe? cafe = await _repository.GetByIdAsync(id);

            if(cafe is null)
            {
                return false;
            }

            await _repository.DeleteAsync(cafe);
            return true;
        }
    }
}