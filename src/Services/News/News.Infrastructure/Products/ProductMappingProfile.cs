using Products.Domain.Dtos.Products;
using AutoMapper;
namespace Products.Infrastructure.Products
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<ProductEntity, ProductReqDto>().ReverseMap();
            CreateMap<ProductEntity, ProductResDto>().ForMember(dest => dest.CategoryTitle_Id,
                config =>
                    config.MapFrom(src => $"{src.Category.Title}({src.CategoryId})")).ReverseMap();
        }
    }
}
