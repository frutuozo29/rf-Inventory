using System;

namespace rf_Inventory.Domain.Entities
{
   public  class Produto
    {
        public Produto()
        {
            
        }

        public long ProdutoId { get; set; }
        public string Nome { get; set; }
        public bool ControlaValidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public long GrupoProdutoId { get; set; }
        public virtual GrupoProduto GrupoProduto { get; set; }

    }
}
