using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces;
using RF.Inventory.Domain.Interfaces.Services;

namespace RF.Inventory.Domain.Services
{
    public class SituacaoDiefService : ServiceBase<SituacaoDief>, ISituacaoDiefService
    {
        private readonly ISituacaoDiefRepository _situacaoDief;

        public SituacaoDiefService(ISituacaoDiefRepository situacaoDief)
            : base(situacaoDief)
        {
            _situacaoDief = situacaoDief;
        }
    }
}
