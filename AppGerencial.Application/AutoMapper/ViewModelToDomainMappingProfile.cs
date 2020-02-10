using AppGerencial.Application.ViewModels;
using AppGerencial.Domain.Entities;
using AutoMapper;


namespace AppGerencial.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TipoViewModel, EntityTipo>().ConstructUsing(c => new EntityTipo(c.ConvertTo()));
            //CreateMap<ProductViewModel, ProductUpdateCommand>().ConstructUsing(c => new ProductUpdateCommand(c.ConvertToProduct()));

            //CreateMap<CategoryViewModel, CategoryAddCommand>().ConstructUsing(c => new CategoryAddCommand(c.ConvertToCategory()));
            //CreateMap<CategoryViewModel, CategoryUpdateCommand>().ConstructUsing(c => new CategoryUpdateCommand(c.ConvertToCategory()));

        }
    }
}
