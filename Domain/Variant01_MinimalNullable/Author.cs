namespace Domain.Variant01_MinimalNullable;

public class Author : AuthorBase
{
    public ICollection<Book> Books { get; }
}