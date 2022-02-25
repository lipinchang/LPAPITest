using Microsoft.EntityFrameworkCore;

namespace LPApi.Models
{
    public class T3ShopContext : DbContext
    {
        public T3ShopContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)   //override onmodel tab
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 101, Name = "Green Peppers", Category = "Vegetable", Price = 1, Qty = 20, Pic = "/img/green.png", Description = "From Malaysia", Status = "In stock" }
                );

            modelBuilder.Entity<User>().HasData(
                new User() { UserId = 1, Role = "shopper" }
                );

            modelBuilder.Entity<ShoppingCartItem>().HasData(
                new ShoppingCartItem() { ShoppingCartId = 1, ProductId = 101, Qty = 3, Amount = 3, UserId = 1 }
                );
        }
    }
}
