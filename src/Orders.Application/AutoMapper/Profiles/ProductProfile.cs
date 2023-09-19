using AutoMapper;
using Orders.Application.Dtos;
using Orders.Domain.Entities.Products;

namespace Orders.Application.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {

        public ProductProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }


    }
}
