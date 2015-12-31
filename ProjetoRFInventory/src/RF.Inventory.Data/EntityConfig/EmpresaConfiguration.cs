using RF.Inventory.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace RF.Inventory.Data.EntityConfig
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            HasKey(e => e.EmpresaId);

            Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(200);

        }
    }
}
