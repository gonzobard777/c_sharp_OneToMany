namespace Domain.Variant02_Without_set_OnParentLink;

public class Author : AuthorBase
{
    public ICollection<Book> Books { get; }
}