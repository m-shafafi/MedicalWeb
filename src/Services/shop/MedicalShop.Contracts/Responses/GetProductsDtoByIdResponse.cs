using MedicalShop.Contracts.Dtos;
using MedicalShop.Contracts.Dtos.Products;

namespace MedicalShop.Contracts.Responses;

public record GetProductByIdResponse(ProductDto ProductDto);