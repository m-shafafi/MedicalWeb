namespace Products.Domain.Dtos.News;
public class News_ArticleDto
{
    public string Title { get; set; }
    public string Summary    { get; set; }
    public string Content { get; set; }
    public int AuthorID { get; set; }
    public int CategoryID { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Tags { get; set; }
    public string ImageURL { get; set; }
    public long ViewsCount { get; set; }
}