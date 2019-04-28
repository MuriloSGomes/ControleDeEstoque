using System;
using System.Collections.Generic;

namespace ProjetoEstoqueDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            //Aquele cliente antigo, que ja ta a mais de 5 anos adiquirindo os serviços da empresa
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}

