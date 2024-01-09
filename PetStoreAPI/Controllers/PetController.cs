using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetStoreAPI.Models;
using PetStoreAPI.Repository;

namespace PetStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository _petRepository;
        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetAllPets()
        {
            return await _petRepository.GetAllPets();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Pet>> GetSinglePet(int id)
        {
            var result = await _petRepository.GetSinglePet(id);
            if (result == null)
                return NotFound("Pet not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Pet>>> AddPet([FromBody] Pet pet)
        {
            var result = await _petRepository.AddPet(pet);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<List<Pet>>> UpdatePet(int id, Pet request)
        {
            var result = await _petRepository.UpdatePet(id, request);
            if (result == null)
                return NotFound("Pet not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Pet>>> DeletePet(int id)
        {
            var result = await _petRepository.DeletePet(id);
            if (result == null)
                return NotFound("Pet not found");

            return Ok(result);
        }
    }
}
