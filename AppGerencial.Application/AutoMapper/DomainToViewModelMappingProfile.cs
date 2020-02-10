
using AppGerencial.Application.ViewModels;
using AppGerencial.Domain.Entities;
using AutoMapper;


namespace AppGerencial.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<EntityTipo, TipoViewModel>();
           
        }
    }
}
