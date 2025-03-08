using MedicalShop.Contracts.Dtos;
using MedicalShop.Contracts.Dtos.Products;

namespace MedicalShop.Contracts.Responses;

public record GetMedicalsResponse(PaginatedList<ProductsDto> Results);