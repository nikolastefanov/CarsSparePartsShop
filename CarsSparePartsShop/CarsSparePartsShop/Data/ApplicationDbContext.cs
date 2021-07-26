
namespace CarsSparePartsShop.Data
{
    using CarsSparePartsShop.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<User> User { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Part> Parts { get; set; }

        public DbSet<OrderPart> OrderParts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Part>()
            .HasOne(p=>p.Category)
            .WithMany(c=>c.Parts)
            .HasForeignKey(p=>p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
          
           builder.Entity<Comment>()
           .HasOne(p => p.User)
           .WithMany(c => c.Comments)
           .HasForeignKey(p => p.UserId)
           .OnDelete(DeleteBehavior.Restrict);
          
           builder.Entity<Order>()
          .HasOne(p => p.User)
          .WithMany(c => c.Orders)
          .HasForeignKey(p => p.UserId)
          .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<OrderPart>()
                .HasKey(x => new { x.PartId, x.OrderId });

            base.OnModelCreating(builder);
        }
    }
}
