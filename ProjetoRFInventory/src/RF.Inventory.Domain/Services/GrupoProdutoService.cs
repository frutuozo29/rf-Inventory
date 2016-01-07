using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces;
using RF.Inventory.Domain.Interfaces.Services;

namespace RF.Inventory.Domain.Services
{
    public class GrupoProdutoService : ServiceBase<GrupoProduto>, IGrupoProdutoService
    {
        private readonly IGrupoProdutoRepository _grupoProduto;

        public GrupoProdutoService(IGrupoProdutoRepository grupoProduto)
            : base (grupoProduto)
        {
            _grupoProduto = grupoProduto;
        }
    }
}
