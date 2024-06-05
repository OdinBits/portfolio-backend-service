using Portfolio_backend_service.Models;

namespace Portfolio_backend_service.Interfaces
{
    public interface IPokemon
    {
        ICollection<Pokemon> GetPokemons()
    }
}
