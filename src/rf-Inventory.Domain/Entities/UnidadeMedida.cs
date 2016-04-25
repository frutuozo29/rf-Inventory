using System;

namespace rf_Inventory.Domain.Entities
{
    public class UnidadeMedida
    {
        public UnidadeMedida()
        {

        }

        public long UnidadeMedidaId { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
