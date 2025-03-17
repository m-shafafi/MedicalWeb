namespace Products.Domain.Dtos.News;
public class News_CategoryDto
{
    string Name { get; set; }
    string Description { get; set; }
    int ParentCategoryID { get; set; }
    string Slug { get; set; }
    DateTime CreatedDate { get; set; }
    DateTime UpdatedDate { get; set; }
}