using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TallyBakery.Application.Core.Infrastructure;

namespace TallyBakery
{
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddInfrastructure(Configuration);
        }
    }
}
