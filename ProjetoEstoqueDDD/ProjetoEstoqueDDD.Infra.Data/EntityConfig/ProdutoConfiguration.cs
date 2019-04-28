using ProjetoEstoqueDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEstoqueDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(produto => produto.ProdutoId);

            Property(produto => produto.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(produto => produto.Valor)
                .IsRequired();

            HasRequired(produto => produto.Cliente)
                .WithMany()
                .HasForeignKey(produto => produto.ClienteId);
        }
    }
}
