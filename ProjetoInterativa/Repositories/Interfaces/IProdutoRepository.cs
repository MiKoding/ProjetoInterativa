using ProjetoInterativa.Models;

namespace ProjetoInterativa.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
    }
}
