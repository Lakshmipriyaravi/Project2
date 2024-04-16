using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cafe_management.Models;

namespace Cafe_management.Configurations
{
    public class CartsConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> modelBuilder)
        {
            modelBuilder.HasKey(c => c.CartId);

            


        }
    }
}
