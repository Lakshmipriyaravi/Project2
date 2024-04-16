using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cafe_management.Models;

namespace Cafe_management.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> modelBuilder)
        {
            modelBuilder.HasKey(p => p.ProductId);
            modelBuilder.Property(p => p.ProductName)
                .IsRequired();
            modelBuilder.Property (p => p.ProductDescription)
                .IsRequired();
            modelBuilder.Property(p => p.ImageUrl)
               .IsRequired();
            modelBuilder.Property(p => p.ProductPrice)
                .IsRequired();
            modelBuilder.Property(p => p.ProductQuantity)
               .IsRequired();

            modelBuilder.HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId)
                .IsRequired();
        }
    }
}
