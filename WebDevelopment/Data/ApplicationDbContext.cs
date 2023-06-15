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

        public DbSet<Make> makes { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Image> images { get; set; }


        

    }
}