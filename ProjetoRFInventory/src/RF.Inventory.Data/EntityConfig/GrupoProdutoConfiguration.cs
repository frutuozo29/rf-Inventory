using RF.Inventory.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace RF.Inventory.Data.EntityConfig
{
    public class GrupoProdutoConfiguration : EntityTypeConfiguration<GrupoProduto>
    {
        public GrupoProdutoConfiguration()
        {
            HasKey(g => g.GrupoProdutoId);

            Property(g => g.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
            
            HasRequired(g => g.Importacao)
                .WithMany()
                .HasForeignKey(g => g.ImportacaoId);

            HasRequired(g => g.SituacaoDief)
                .WithMany()
                .HasForeignKey(g => g.SituacaoDiefId);
        }
    }
}
