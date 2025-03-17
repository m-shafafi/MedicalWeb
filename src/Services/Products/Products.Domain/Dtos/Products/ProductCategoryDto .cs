namespace Products.Domain.Dtos.Products;
public class ProductCategoryDto
{
    string Name { get; set; }
    string Description { get; set; }
    int? ParentCategoryID { get; set; }
}

