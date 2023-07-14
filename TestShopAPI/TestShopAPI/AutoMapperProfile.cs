using AutoMapper;
using TestShopAPI.Models;
using TestShopAPI.Models.DTO;

namespace TestShopAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<ClientDTO, Client>();
            CreateMap<ShopDTO, Shop>();
            CreateMap<OrderDTO, Order>();
        }
    }
}
