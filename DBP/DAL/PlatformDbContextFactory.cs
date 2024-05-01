using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace DAL
{
    public class PlatformDbContextFactory : IDesignTimeDbContextFactory<PlatformDbContext>
    {
        public PlatformDbContext CreateDbContext(string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder(args).Build();

            IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

            var connectionString = config.GetValue<string>("ConnectionStrings:Prod");

            var optionsBuilder = new DbContextOptionsBuilder<PlatformDbContext>();
            optionsBuilder.UseMySQL(connectionString ?? "");

            return new PlatformDbContext(optionsBuilder.Options);
        }
    }
}