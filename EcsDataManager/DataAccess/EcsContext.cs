using EcsDataManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcsDataManager.DataAccess
{
    public class EcsContext : DbContext
    {
        public EcsContext() { }

        public EcsContext(DbContextOptions<EcsContext> options) : base(options) { }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<ApnCustomers> ApnCustomers { get; set; }
        public virtual DbSet<CustomerUrl> CustomerUrl { get; set; }
        public virtual DbSet<DeviceList> DeviceList { get; set; }

        public virtual DbSet<IntranetCustomers> IntranetCustomers { get; set; }



    }
}
