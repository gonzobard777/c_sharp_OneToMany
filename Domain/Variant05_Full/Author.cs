namespace Domain.Variant05_Full;

public class Author : AuthorBase
{
    /*
     * One Author - to - Many Book
     */
    public ICollection<Book>? Books { get; }
}