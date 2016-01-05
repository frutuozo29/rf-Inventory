using RF.Inventory.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace RF.Inventory.Data.EntityConfig
{
    class SituacaoDiefConfiguration : EntityTypeConfiguration<SituacaoDief>
    {
        public SituacaoDiefConfiguration()
        {
            HasKey(s => s.SituacaoDiefId);

            Property(s => s.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);
        }
    }
}
