using MediatR;
using MedicalShop.Contracts.Dtos.Products;

namespace Medicals.Application.Commands.Medicals.CreateMedical;

public record CreateProductCommand(int Id, string Name, string Description, decimal Price, int? BrandID, int? CategoryID, string StockQuantity, string SKU, string ImageURL, string Warranty, int Rating) : IRequest<ProductsDto>;