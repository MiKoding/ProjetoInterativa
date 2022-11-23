using ProjetoInterativa.Context;
using ProjetoInterativa.Models;
using ProjetoInterativa.Repositories.Interfaces;

namespace ProjetoInterativa.Repositories
{
    public class FabricanteRepository : IFabricanteRepository
    {
        private readonly AppDbContext _context;
        public FabricanteRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Fabricante> Fabricantes => _context.Fabricantes;

    }
}
