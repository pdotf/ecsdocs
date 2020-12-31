using EcsDataManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcsDataManager.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() { }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        public DbSet<Customers>  Customers { get; set; }
        public DbSet<ApnCustomers>  ApnCustomers { get; set; }
        public DbSet<CustomerUrl> CustomerUrl { get; set; }
        public DbSet<DeviceList>  DeviceList { get; set; }



    }
}
