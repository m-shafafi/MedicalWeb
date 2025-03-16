namespace MedicalShop.Contracts.Dtos.Products;

public class ProductDto 
{

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int? BrandID { get; set; }
    public int? CategoryID { get; set; }
    public string StockQuantity { get; set; }
    public string SKU { get; set; }
    public string ImageURL { get; set; }
    public string Warranty { get; set; }
    public int Rating { get; set; }


}
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


public class ProductReqDto : ProductDto
{

    public int CategoryId { get; set; }

}

public class ProductResDto : ProductDto
{
    public int CategoryId { get; set; }
    public string CategoryTitle_Id { get; set; }
    public string CategoryTitle { get; set; }

}