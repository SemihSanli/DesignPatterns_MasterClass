using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ObserverDesignPattern.DAL.Entities;

namespace ObserverDesignPattern.DAL.Context
{
    public class ObserverDbContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-33VDDOP\\SQLEXPRESS17;database=ObserverDesignPatternDB;integrated security=true;trustServerCertificate=true;");
        }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Logging> Loggings { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
    }
}
