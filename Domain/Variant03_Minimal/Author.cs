namespace Domain.Variant03_Minimal;

public class Author : AuthorBase
{
    public ICollection<Book> Books { get; }
}