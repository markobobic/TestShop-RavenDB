using AutoMapper;
using TestShop_RavenDB.Core.DTOs;
using TestShop_RavenDB.Core.Entities;
using TestShop_RavenDB.Core.ValueObjects;

namespace TestShop_RavenDB.WebApi.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderLine, OrderLineCreateDTO>()
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(x => x.ProductId))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(x => x.Quantity));

            CreateMap<Order, OrderCreateDTO>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(x => x.CustomerId))
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(x => x.Discount));

            CreateMap<OrderCreateDTO, Order>()
                .ConstructUsing(x => new Order(x.CustomerId, x.Discount));

            CreateMap<OrderLineCreateDTO, OrderLine>()
                .ConstructUsing(x => new OrderLine(x.ProductId, x.Quantity));
        }
    }
}
