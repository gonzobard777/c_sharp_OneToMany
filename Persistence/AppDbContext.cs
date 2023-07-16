using Microsoft.EntityFrameworkCore;
using Domain.Variant05_Full;

namespace Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    public AppDbContext(DbContextOptions opt) : base(opt)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(b =>
        {
            b.ToTable("Authors");
            b.HasKey(x => x.Id).HasName("PK_Authors_Id");
        });
        
        /*
         * One Author - to - Many Book
         */
        modelBuilder.Entity<Book>(b =>
        {
            b.ToTable("Books");
            b.HasKey(x => x.Id).HasName("PK_Books_Id");
        
            b
                .HasOne(book => book.Author)
                .WithMany(author => author.Books)
                .HasForeignKey(book => book.AuthorId)
                .HasConstraintName("FK_Books_AuthorId")
                .OnDelete(DeleteBehavior.Cascade);
            b.HasIndex(x => x.AuthorId, "IX_Books_AuthorId").IsUnique(false);
        });
    }
}