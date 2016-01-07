using RF.Inventory.Application.Interfaces;
using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces.Services;

namespace RF.Inventory.Application
{
    public class EmpresaAppService : AppServiceBase<Empresa>, IEmpresaAppService
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaAppService(IEmpresaService empresaService)
            : base(empresaService)
        {
            _empresaService = empresaService;
        }
    }
}
