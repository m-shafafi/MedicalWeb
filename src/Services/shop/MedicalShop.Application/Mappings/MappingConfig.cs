using Mapster;
using MedicalShop.Contracts.Dtos;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Contracts.Responses;

namespace MedicalShop.Application.Mappings;

public class MappingConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<PaginatedList<ProductsDto>, GetMedicalsResponse>.NewConfig()
            .Map(dest => dest.Results, src => src);

        TypeAdapterConfig<ProductEntity, GetProductByIdResponse>.NewConfig()
            .Map(dest => dest.ProductsDto, src => src);
    }
}