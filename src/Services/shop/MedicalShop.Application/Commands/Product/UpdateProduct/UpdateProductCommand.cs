using MediatR;

namespace MedicalShop.Application.Commands.Medicals.UpdateProduct;

public record UpdateProductCommand(int Id,string Name, string Description, decimal Price, int? BrandID, int? CategoryID, string StockQuantity, string SKU, string ImageURL, string Warranty, int Rating) : IRequest<Unit>;