namespace Domain.Variant04_Minimal_WithoutChildrenCollection;

public class Book : BookBase
{
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}