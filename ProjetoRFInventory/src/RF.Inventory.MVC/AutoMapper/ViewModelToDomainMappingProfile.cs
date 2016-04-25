using AutoMapper;
using RF.Inventory.Domain.Entities;
using RF.Inventory.MVC.ViewModels;

namespace RF.Inventory.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Empresa, EmpresaViewModel>();
            Mapper.CreateMap<SituacaoDief, SituacaoDiefViewModel>();
        }
    }
}