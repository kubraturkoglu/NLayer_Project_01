using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                     new ProductFeature { Id = 1, ProductId = 1, color = "blue" },
                     new ProductFeature { Id = 2, ProductId = 1, color = "red" },
                     new ProductFeature { Id = 3, ProductId = 2, color = "yellow" });
        }

    }
}
