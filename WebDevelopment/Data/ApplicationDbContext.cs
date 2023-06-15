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
           /* builder.Entity<Make>().HasData(
        new Make { Id = 1, Name = "Mercedes" },
        new Make { Id = 2, Name = "Nissan" },
        new Make { Id = 3, Name = "Toyota" }
    );*/

            // Seed the 'Model' entities
            builder.Entity<Model>().HasData(
                new Model { MakeId = 1, Id = 1, Name = "C-Class" },
                new Model { MakeId = 1, Id = 2, Name = "E-Class" },
                new Model { MakeId = 2, Id = 3, Name = "Juke" },
                new Model { MakeId = 2, Id = 4, Name = "Teana" },
                new Model { MakeId = 3, Id = 5, Name = "Camry" },
                new Model { MakeId = 3, Id = 6, Name = "Corolla" }
            );



        }


        public DbSet<Make> makes { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Image> images { get; set; }


        

    }
}