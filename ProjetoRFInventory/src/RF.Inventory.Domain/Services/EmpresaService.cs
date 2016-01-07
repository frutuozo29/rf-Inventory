using System;
using System.Collections.Generic;
using RF.Inventory.Domain.Entities;
using RF.Inventory.Domain.Interfaces.Services;
using RF.Inventory.Domain.Interfaces;

namespace RF.Inventory.Domain.Services
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
            : base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
    }
}
