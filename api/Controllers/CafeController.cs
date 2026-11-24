using api.Dtos;
using api.Services;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    [ApiController] //This line turns on our API Features Like Automatic 400 status code
    [Route("api/[controller]")]
    public class CafeController : ControllerBase
    {
        private readonly ICafeServices _services;

        public CafeController(ICafeServices services)
        {
            _services = services;
        }

        //async Task<..>: the action awaits the services, so it returns a Task
        //ASP.NET Core awaits the Task for us, then sends the response.

        [HttpGet]
        public async Task<ActionResult<List<CafeResponseDto>>> GetAll()
        {
            //await frees this thread while the database works,
            //so the server can handle other requests in the meantime.
            return Ok(await _services.GetAllAsync());
        }


        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<CafeResponseDto>> GetById(int id)
        {
            CafeResponseDto? cafe = await _services.GetByIdAsync(id);

            if(cafe == null)
            {
                return NotFound("There was no cafe with that id found."); // sends a 404 response
            }
            return Ok(cafe);
        }


        [HttpPost("Add")]
        public async Task<ActionResult<CafeResponseDto>> AddCafe([FromBody] CreateCafeDto dto)
        {
            CafeResponseDto cafe = await _services.CreateAsync(dto);

            //created at action sends 201, It uses GetById id action and the new Id
            //To build the location headers
            return CreatedAtAction(nameof(GetById), new {id = cafe.Id}, cafe);
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult<CafeResponseDto>> Update(int id, [FromBody] UpdateCafeDto dto)
        {
            CafeResponseDto? cafe = await _services.UpdateAsync(id, dto);

            if(cafe is null)
            {
                return NotFound("There was no cafe with that id found.");
            }

            return Ok(cafe);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool isDeleted = await _services.DeleteAsync(id);

            if (!isDeleted)
            {
                return NotFound("There was no cafe with that id found.");
            }

            //This worked and theres nothing to send back 204 status code
            return NoContent();
        }
    }
}