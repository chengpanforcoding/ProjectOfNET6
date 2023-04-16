using Microsoft.EntityFrameworkCore;
using SideProjectForNET6.Models;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

namespace ProjectOfNET6.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string PJsondata = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+ @"/Database/touristRoutesMockData.json");
            IList<Product> P = JsonSerializer.Deserialize<IList<Product>>(PJsondata);
            modelBuilder.Entity<Product>().HasData(P);

            string PCJsondata = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutePicturesMockData.json");
            IList<ProductPicture> PC = JsonSerializer.Deserialize<IList<ProductPicture>>(PCJsondata);
            modelBuilder.Entity<ProductPicture>().HasData(PC);

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
