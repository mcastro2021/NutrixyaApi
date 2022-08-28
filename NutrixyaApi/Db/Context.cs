using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using NutrixyaApi.Models;

namespace NutrixyaApi.Db
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DevConnection"));


        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Lot> Lots { get; set; }


    }
}
