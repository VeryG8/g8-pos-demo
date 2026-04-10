using G8.PosDemo.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace G8.PosDemo.Web.Data;

public class PosDbContext(DbContextOptions<PosDbContext> options) : DbContext(options)
{
    public DbSet<ProductCategoryEntity> ProductCategories => Set<ProductCategoryEntity>();
    public DbSet<ProductEntity> Products => Set<ProductEntity>();
    public DbSet<OrderEntity> Orders => Set<OrderEntity>();
    public DbSet<OrderItemEntity> OrderItems => Set<OrderItemEntity>();
    public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();
    public DbSet<PromotionEntity> Promotions => Set<PromotionEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCategoryEntity>().HasData(
            new ProductCategoryEntity { Id = 1, Name = "招牌茶類", SortOrder = 1 },
            new ProductCategoryEntity { Id = 2, Name = "奶茶系列", SortOrder = 2 },
            new ProductCategoryEntity { Id = 3, Name = "特調系列", SortOrder = 3 }
        );

        modelBuilder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, CategoryId = 1, Name = "茉莉綠茶", BasePrice = 35m, SizeOptions = "M,L", IsTea = true, IsEnabled = true },
            new ProductEntity { Id = 2, CategoryId = 1, Name = "阿薩姆紅茶", BasePrice = 35m, SizeOptions = "M,L", IsTea = true, IsEnabled = true },
            new ProductEntity { Id = 3, CategoryId = 2, Name = "珍珠奶茶", BasePrice = 60m, SizeOptions = "L", IsTea = false, IsEnabled = true },
            new ProductEntity { Id = 4, CategoryId = 2, Name = "黑糖鮮奶", BasePrice = 75m, SizeOptions = "M", IsTea = false, IsEnabled = true },
            new ProductEntity { Id = 5, CategoryId = 3, Name = "葡萄柚綠", BasePrice = 70m, SizeOptions = "L", IsTea = true, IsEnabled = true }
        );

        modelBuilder.Entity<PromotionEntity>().HasData(
            new PromotionEntity
            {
                Id = 1,
                Name = "外帶買五送一",
                PromotionType = "BuyXGetY",
                OrderTypeScope = "Takeout",
                BuyQuantity = 5,
                FreeQuantity = 1,
                IsEnabled = true,
                SortOrder = 1
            }
        );
    }
}
