using System;

namespace rf_Inventory.Domain.Entities
{
    public class Empresa
    {
        public Empresa() { }

        public long EmpresaId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public long CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public bool EmpresaAtiva() => Ativo == true;
        
    }
}
