using System;
using System.Collections.Generic;

namespace RF.Inventory.Domain.Entities
{
    public class Importacao
    {
        public long ImportacaoId { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }
        
        public long EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual IEnumerable<GrupoProduto> Grupos { get; set; }
    }
}