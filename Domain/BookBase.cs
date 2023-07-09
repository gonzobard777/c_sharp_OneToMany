using Microsoft.EntityFrameworkCore;

namespace Domain;

public class BookBase
{
    public int Id { get; init; }
    public string Title { get; init; }
}