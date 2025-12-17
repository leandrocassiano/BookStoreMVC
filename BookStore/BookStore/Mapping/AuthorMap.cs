using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class AuthorMap: EntityTypeConfiguration<Author>
    {
        public AuthorMap() 
        {
            ToTable("Authors");
            HasKey(a => a.Id);
            Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(200);
            HasMany(a => a.Books)
                .WithMany(b => b.Authors)
                .Map(ab =>
                {
                    ab.ToTable("BookAuthors");
                    ab.MapLeftKey("AuthorId");
                    ab.MapRightKey("BookId");
                });
        }
    }
}