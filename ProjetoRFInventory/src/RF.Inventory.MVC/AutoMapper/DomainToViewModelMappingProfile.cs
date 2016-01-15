using AutoMapper;
using RF.Inventory.Domain.Entities;
using RF.Inventory.MVC.ViewModels;

namespace RF.Inventory.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        protected override void Configure()
        {
            Mapper.CreateMap<EmpresaViewModel, Empresa>();
            Mapper.CreateMap<SituacaoDiefViewModel, SituacaoDief>();
        }

    }
}