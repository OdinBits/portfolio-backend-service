using Microsoft.AspNetCore.Mvc;
using Portfolio_backend_service.Models;
using Portfolio_backend_service.Repository;

namespace Portfolio_backend_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonRepository _repository;
        public PokemonController(PokemonRepository PokemonRepository)
        {
            _repository = PokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _repository.GetPokemons();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }
    }
}
