using AutoMapper;
using TestShop_RavenDB.Core.DTOs;
using TestShop_RavenDB.Core.Entities;
using TestShop_RavenDB.Core.ValueObjects;

namespace TestShop_RavenDB.WebApi.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductCreateDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(x => x.Price.Amount));
            
            CreateMap<ProductCreateDTO, Product>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(x => new ProductName(x.Name)))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(x => new Price(x.Price)));
        }
    }
}
