using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                     new Product { 
                         Id = 1,
                         CategoryId = 1,
                         Price = 18,
                         Stock = 39,
                         Name = "Chai",
                         CreatedDate = DateTime.Now
                     },
                     new Product {
                         Id = 2,
                         CategoryId = 1,
                         Price = 19,
                         Stock = 17,
                         Name = "Chang",
                         CreatedDate= DateTime.Now
                     },
                     new Product {
                         Id = 3,
                         CategoryId = 2,
                         Price = 10,
                         Stock = 13,
                         Name = "Aniseed Syrup",
                         CreatedDate = DateTime.Now
                     });
        }
    }
}
