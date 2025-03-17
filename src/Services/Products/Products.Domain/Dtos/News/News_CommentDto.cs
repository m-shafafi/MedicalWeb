namespace Products.Domain.Dtos.News;
public class News_CommentDto {
    int NewsArticleID { get; set; } 
    string Content { get; set; } 
    DateTime PostedDate { get; set; }
}
