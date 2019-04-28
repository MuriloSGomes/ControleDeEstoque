using ProjetoEstoqueDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEstoqueDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(clienteId => clienteId.ClienteId);

            Property(cliente => cliente.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(cliente => cliente.SobreNome)
                .IsRequired()
                .HasMaxLength(150);

            Property(cliente => cliente.Email)
                .IsRequired();
        }
    }
}
