using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class CategoryMap :EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories");
            HasKey(c => c.Id);
            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);
            HasMany(c => c.Books)
                .WithRequired(b => b.Category)
                .HasForeignKey(b => b.CategoryId);
        }
    }    
}