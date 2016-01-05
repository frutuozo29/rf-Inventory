using System;

namespace RF.Inventory.Domain.Entities
{
    public class GrupoProduto
    {
        public long GrupoProdutoId { get; set; }

        public long Codigo { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public long SituacaoDiefId { get; set; }

        public virtual SituacaoDief SituacaoDief { get; set; }
        
        public long ImportacaoId { get; set; }

        public virtual Importacao Importacao { get; set; }
        
        public long EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }


    }
}
