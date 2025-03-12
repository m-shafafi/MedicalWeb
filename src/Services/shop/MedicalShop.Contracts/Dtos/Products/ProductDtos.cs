namespace MedicalShop.Contracts.Dtos.Products;

public record ProductDto(int Id, string Name, string Description, decimal Price, int? BrandID, int? CategoryID, string StockQuantity, string SKU, string ImageURL, string Warranty, int Rating);
public class ProductFilterPageReqDto
{
    public int Id { get; set; }
    public string SearchTerm { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public int CategoryId { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }


}


public record ProductResDto(int CategoryID);
public record ProductReqDto(int CategoryID);
