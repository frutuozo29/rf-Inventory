using RF.Inventory.Application.Interfaces;
using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces.Services;

namespace RF.Inventory.Application
{
    public class ImportacaoAppService : AppServiceBase<Importacao>, IImportacaoAppService
    {
        private readonly IImportacaoService _importacao;

        public ImportacaoAppService(IImportacaoService importacao)
            : base(importacao)
        {
            _importacao = importacao;
        }
    }
}