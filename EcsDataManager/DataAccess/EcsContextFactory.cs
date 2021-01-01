using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EcsDataManager.DataAccess
{
    public class EcsContextFactory : IDesignTimeDbContextFactory<EcsContext>
    {
        public EcsContextFactory()
        {

        }

        private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        public EcsContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EcsContext>();
            builder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            return new EcsContext(builder.Options);
        }
    }
}
