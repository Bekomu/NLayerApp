using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() { Id = 1, Name="ViewSonic M3211", CategoryId=1, Price=7000, Stock=20, CreatedDate=DateTime.Now },
                new Product() { Id = 2, Name="Asus Tuf RGB", CategoryId = 2, Price = 700, Stock = 30, CreatedDate = DateTime.Now },            "",
                new Product() { Id = 3, Name="Gigabyte RTX 3060 Ti", CategoryId = 3, Price = 7000, Stock = 10, CreatedDate = DateTime.Now }
                );
        }
    }
}
