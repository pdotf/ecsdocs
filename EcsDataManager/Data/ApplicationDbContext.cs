using EcsDataManager.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcsDataManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<VpnCustomers> VpnCustomers { get; set; }
        public virtual DbSet<ApnCustomers> ApnCustomers { get; set; }
        public virtual DbSet<CustomerUrl> VpnCustomerUrl { get; set; }
        public virtual DbSet<DeviceList> VpnDeviceList { get; set; }

        public virtual DbSet<IntranetCustomers> IntranetCustomers { get; set; }
        public virtual DbSet<Coordinators> Coordinators { get; set; }

    }
}
