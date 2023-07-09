namespace Domain.Variant05_Full;

public class Author : AuthorBase
{
    /*
     * One Author - to - many Book
     */
    public ICollection<Book>? Books { get; }
}