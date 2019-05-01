using ProjetoEstoqueDDD.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoEstoqueDDD.Domain.Interfaces
{
    public interface IProdutoRepository: IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
