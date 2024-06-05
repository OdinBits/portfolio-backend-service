using Portfolio_backend_service.Data;
using Portfolio_backend_service.Interfaces;
using Portfolio_backend_service.Models;

namespace Portfolio_backend_service.Repository
{
    public class PokemonRepository : IPokemon
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        { 
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons() 
        { 
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
 