using AjaxNightNew.Entities;
using Microsoft.EntityFrameworkCore;

namespace AjaxNightNew.Context
{
    public class AjaxContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AHMBJB5\\SQLEXPRESS;initial catalog=AjaxNightDb;integrated security=true;TrustServerCertificate=true");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
