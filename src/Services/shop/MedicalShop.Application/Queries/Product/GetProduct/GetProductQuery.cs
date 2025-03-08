using MediatR;
using MedicalShop.Contracts.Dtos;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Contracts.Requests.Common;
using MedicalShop.Contracts.Responses;

namespace MedicalShop.Application.Queries.Product.GetProduct;

public record GetProductQuery(PaginationParams PaginationParams) : IRequest<PaginatedList<ProductsDto>>;