using Microsoft.EntityFrameworkCore;
using Opimerchant.Models;

namespace Opimerchant.Data
{
    public class OpimerchantDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Opimerchant;Trusted_Connection=True;");
        }
    }
}
