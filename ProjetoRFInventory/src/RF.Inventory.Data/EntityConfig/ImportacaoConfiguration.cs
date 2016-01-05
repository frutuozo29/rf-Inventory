using RF.Inventory.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace RF.Inventory.Data.EntityConfig
{
    public class ImportacaoConfiguration : EntityTypeConfiguration<Importacao>
    {
        public ImportacaoConfiguration()
        {
            HasKey(i => i.ImportacaoId);

            Property(i => i.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            HasRequired(i => i.Empresa)
                .WithMany()
                .HasForeignKey(i => i.EmpresaId);

        }
    }
}
