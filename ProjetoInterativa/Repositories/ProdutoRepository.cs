using ProjetoInterativa.Context;
using ProjetoInterativa.Models;
using ProjetoInterativa.Repositories.Interfaces;

namespace ProjetoInterativa.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos;
    }
}
