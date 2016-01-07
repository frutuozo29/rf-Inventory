using RF.Inventory.Application.Interfaces;
using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces.Services;

namespace RF.Inventory.Application
{
    public class GrupoProdutoAppService : AppServiceBase<GrupoProduto>, IGrupoProdutoAppService
    {
        private readonly IGrupoProdutoService _grupo;

        public GrupoProdutoAppService(IGrupoProdutoService grupo)
            : base(grupo)
        {
            _grupo = grupo;
        }
    }
}
