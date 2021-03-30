using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarContext : DbContext
    {
        //Hangi data ile kullanacagını gosterdigin yer.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentCar;Trusted_Connection=true");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\projectsV13;Database=Northwind;Trusted_Connection=true");
        }
        //Neyin neye karsılık gelecegini yazdık.
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
