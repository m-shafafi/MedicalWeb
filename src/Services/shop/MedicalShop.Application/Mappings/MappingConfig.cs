using Mapster;
using MedicalShop.Contracts.Dtos;
using MedicalShop.Contracts.Responses;

namespace Medicals.Application.Mappings;

public class MappingConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<PaginatedList<MedicalsDto>, GetMedicalsResponse>.NewConfig()
            .Map(dest => dest.Results, src => src);

        TypeAdapterConfig<Medical, GetMedicalByIdResponse>.NewConfig()
            .Map(dest => dest.MedicalDto, src => src);
    }
}