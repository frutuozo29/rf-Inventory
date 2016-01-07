using RF.Inventory.Application.Interfaces;
using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces.Services;

namespace RF.Inventory.Application
{
    public class SituacaoDiefAppService : AppServiceBase<SituacaoDief>, ISituacaoDiefAppService
    {
        private readonly ISituacaoDiefService _situacaoDief;

        public SituacaoDiefAppService(ISituacaoDiefService situacaoDief)
            : base(situacaoDief)
        {
            _situacaoDief = situacaoDief;
        }
    }
}
