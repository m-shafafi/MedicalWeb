namespace MedicalShop.Contracts.Dtos.News;
public record News_ArticleDto(string Title, string Summary,string Content, int AuthorID, 
    
    int CategoryID,DateTime PublishedDate ,string Tags , string ImageURL , long ViewsCount);
