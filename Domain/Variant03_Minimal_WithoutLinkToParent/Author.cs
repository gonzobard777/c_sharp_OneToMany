namespace Domain.Variant03_Minimal_WithoutLinkToParent;

public class Author : AuthorBase
{
    public ICollection<Book> Books { get; }
}