using AppDiyet.Core.Concretes;
using AppDiyet.Repo.Configs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Repo.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategories> FoodCategories { get; set; }
        public DbSet<Meals> Meals { get; set; } 
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=VICTUS;Database=AppDiyet; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigFood());
            modelBuilder.ApplyConfiguration(new ConfigFoodCategories());
            modelBuilder.ApplyConfiguration(new ConfigMeals());
            modelBuilder.ApplyConfiguration(new ConfigUsers());
        }
    }
}
