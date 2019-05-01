using ProjetoEstoqueDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstoqueDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(produto => produto.Nome == nome);
        }
    }
}
