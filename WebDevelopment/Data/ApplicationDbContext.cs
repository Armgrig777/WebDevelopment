using Car_Sales.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace WebDevelopment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Model>()
                .HasOne(m => m.Make)
                .WithMany(m => m.Models)
                .HasForeignKey(m => m.MakeId);
            builder.Entity<Car>()
                .HasOne(c => c.Model)
                .WithMany(c => c.Cars)
                .HasForeignKey(c => c.ModelId);
        }


        public DbSet<Make> makes { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Image> images { get; set; }


        

    }
}