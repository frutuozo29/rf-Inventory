using System;

namespace rf_Inventory.Domain.Entities
{
    public class GrupoProduto
    {
        public GrupoProduto()
        {

        }

        public long GrupoProdutoId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
