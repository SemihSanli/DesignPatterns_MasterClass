using ChainOfResponsibilityPattern.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibilityPattern.DAL.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server=DESKTOP-33VDDOP\\SQLEXPRESS17;database=ChainOfResponsibilityPatternDB;integrated security=true;trustServerCertificate=true;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
