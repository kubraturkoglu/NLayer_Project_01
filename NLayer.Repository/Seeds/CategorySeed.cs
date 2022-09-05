using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Beverages" },
                new Category { Id = 2, Name = "Condiments" },
                new Category { Id = 3, Name = "Confections" },
                new Category { Id = 4, Name = "Dairy Products" },
                new Category { Id = 5, Name = "Grains/Cereals" },
                new Category { Id = 6, Name = "Meat/Poultry" },
                new Category { Id = 7, Name = "Produce" },
                new Category { Id = 8, Name = "Seafood" });
           

        }
    }
}
