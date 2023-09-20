using AutoMapper;
using Basket.Application.Dtos;
using Basket.Domain.Entities.Products;

namespace Basket.Application.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {

        public ProductProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }


    }
}
