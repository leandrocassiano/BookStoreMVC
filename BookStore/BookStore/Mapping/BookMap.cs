using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class BookMap: EntityTypeConfiguration<Book>
    {
        public BookMap() 
        { 
            ToTable("Books");
            HasKey(b => b.Id);
            Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(200);
            Property(b => b.ISBN)
                .IsRequired()
                .HasMaxLength(13);
            Property(b => b.ReleaseDate);
        }
    }
}