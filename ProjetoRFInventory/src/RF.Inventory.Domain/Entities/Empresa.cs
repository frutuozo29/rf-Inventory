using System;

namespace RF.Inventory.Domain.Entities
{
    public class Empresa
    {
        public long EmpresaId { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool UtilizarDIEF { get; set; }
        
    }
}
