using Car_Sales.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Emit;
using WebDevelopment.Controllers;

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
            // Seed models and makes
            builder.Entity<Make>().HasData(
                new Make { Id = 1, Name = "Toyota" },
                new Make { Id = 2, Name = "Ford" },
                new Make { Id = 3, Name = "Chevrolet" }
            );

            //builder.Entity<Model>().HasData(
            //    new Model { Id = 1, Name = "Corolla", MakeId = 1 },
            //    new Model { Id = 2, Name = "Camry", MakeId = 1 },
            //    new Model { Id = 3, Name = "F-150", MakeId = 2 },
            //    new Model { Id = 4, Name = "Mustang", MakeId = 2 },
            //    new Model { Id = 5, Name = "Silverado", MakeId = 3 },
            //    new Model { Id = 6, Name = "Equinox", MakeId = 3 }
            //);


			base.OnModelCreating(builder);
		}

		public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}