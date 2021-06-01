using CasaDoCodigo.Models;
using CasaDoCodigo.Services;
using System.Collections.Generic;

namespace CasaDoCodigo.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);

        IList<Produto> GetProdutos();
    }
}