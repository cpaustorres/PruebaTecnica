using Microsoft.EntityFrameworkCore;
using Pruebalocal.Models;

namespace Pruebalocal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserViewModel> Users { get; set; }
        public DbSet<VehicleViewModel> Vehicles { get; set; }

 
    }
}