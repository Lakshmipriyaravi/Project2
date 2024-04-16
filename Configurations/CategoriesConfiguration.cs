using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cafe_management.Models;

namespace Cafe_management.Configurations
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> modelBuilder)
        {
            modelBuilder.HasKey(c => c.CategoryId);
            modelBuilder.Property(c => c.CategoryName)
                        .IsRequired();
            modelBuilder.Property(c=>c.ImageUrl)
                        .IsRequired();

            

            
        }
    }
}
