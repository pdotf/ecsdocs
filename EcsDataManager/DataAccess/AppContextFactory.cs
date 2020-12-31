using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EcsDataManager.DataAccess
{
    public class AppContextFactory : IDesignTimeDbContextFactory<AppContext>
    {
        public AppContextFactory()
        {

        }

        private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        public AppContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppContext>();
            builder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            return new AppContext(builder.Options);
        }
    }
}
