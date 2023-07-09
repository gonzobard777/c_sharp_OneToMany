namespace Domain.Variant05_Full;

public class Book : BookBase
{
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}