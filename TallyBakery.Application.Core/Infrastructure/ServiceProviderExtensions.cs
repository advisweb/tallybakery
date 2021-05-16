using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TallyBakery.Application.Core.Entities;
using TallyBakery.Application.Core.Interfaces;
using TallyBakery.Application.Persistence;

namespace TallyBakery.Application.Core.Infrastructure
{
    public static class ServiceProviderExtensions
    {
        public static void AddTallyDbContext(this IServiceCollection services, Action<ITallyBakeryDbContext> option = null)
        {
            var dbContext = new TallyBakeryDbContext<Product>();
            if (option != null)
            {
                option.Invoke(dbContext);
            }
            services.AddSingleton(typeof(ITallyBakeryDbContext), dbContext);
        }

        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var sampleDataConfig = configuration
                .GetSection("SampleData")
                .Get<SampleDataOptions>();

            services.Scan(scan => scan
                .FromAssembliesOf(typeof(ITallyBakery))
                .AddClasses()
                .AsImplementedInterfaces()
                .WithScopedLifetime()
            ).AddLogging(l => l.AddConsole());
            services.AddTallyDbContext(opt => opt.UseFilename(sampleDataConfig.Filename));
        }
    }
}
