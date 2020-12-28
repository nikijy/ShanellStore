using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShanellStore.DataLayer.Entities.Blog;
using ShanellStore.DataLayer.Entities.Orders;
using ShanellStore.DataLayer.Entities.Permission;
using ShanellStore.DataLayer.Entities.Product;
using ShanellStore.DataLayer.Entities.User;

namespace ShanellStore.DataLayer.Context
{
    public class ShanellStoreContext : DbContext
    {
       
        public ShanellStoreContext(DbContextOptions<ShanellStoreContext> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

        #endregion

        #region Product

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }


        #endregion

        #region permission

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }


        #endregion

        #region Orders

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserBasket> UserBaskets { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        #endregion

        #region blog

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }


        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDeleted.Value);
            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDeleted.Value);
            modelBuilder.Entity<Category>()
                .HasQueryFilter(r => !r.IsDeleted.Value);
            modelBuilder.Entity<Product>()
                .HasQueryFilter(r => !r.IsDeleted.Value);
            modelBuilder.Entity<Blog>()
                .HasQueryFilter(r => !r.IsDeleted.Value);
            modelBuilder.Entity<UserMessage>()
                .HasQueryFilter(r => !r.IsDeleted.Value);
            modelBuilder.Entity<BlogComment>()
                .HasQueryFilter(r => !r.IsDeleted.Value);
            modelBuilder.Entity<Discount>()
                .HasQueryFilter(r => !r.IsDeleted.Value);

            base.OnModelCreating(modelBuilder);
        }
    }
}
