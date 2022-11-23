using ProjetoInterativa.Models;

namespace ProjetoInterativa.Repositories.Interfaces
{
    public interface IFabricanteRepository
    {
        IEnumerable<Fabricante> Fabricantes { get; }
    }
}
