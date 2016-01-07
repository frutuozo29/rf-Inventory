using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces;
using RF.Inventory.Domain.Interfaces.Services;

namespace RF.Inventory.Domain.Services
{
    public class ImportacaoService : ServiceBase<Importacao>, IImportacaoService
    {
        private readonly IImportacaoRepository _importacao;

        public ImportacaoService(IImportacaoRepository importacao)
            : base(importacao)
        {

        }

    }
}
