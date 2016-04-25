namespace rf_Inventory.Domain.Entities
{
    public class Cidade
    {
        public Cidade()
        {

        }

        public long CidadeId { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public virtual UF UF { get; set; }
        public string CodigoIBGE { get; set; }
    }
}
