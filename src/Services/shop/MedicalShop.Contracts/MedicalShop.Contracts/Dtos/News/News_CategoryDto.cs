namespace MedicalShop.Contracts.Dtos.News;
public record News_CategoryDto(string Name, string Description, int ParentCategoryID, string Slug
  , DateTime CreatedDate, DateTime UpdatedDate);