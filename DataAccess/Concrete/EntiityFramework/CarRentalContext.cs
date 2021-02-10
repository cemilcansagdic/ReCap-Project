using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities;

namespace DataAccess.Concrete.EntiityFramework
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarRentalDatabase;Trusted_Connection=true");
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
