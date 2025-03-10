namespace MedicalShop.Contracts.Dtos.Products;

public record ProductsDto(string Name,string Description,decimal Price,int? BrandID,int? CategoryID,string StockQuantity,string SKU,string ImageURL,string Warranty,int Rating);