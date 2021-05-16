using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Core.Entities;
using TallyBakery.Application.Persistence;

namespace TallyBakery.Application.Test.Infrastructure
{
    public class FilebaseContext : IContextFactory
    {        
        public static ITallyBakeryDbContext CreateContext()
        {
            var context = new TallyBakeryDbContext<Product>();
            context.UseFilename("db.json");
            return context;
        }
    }
}
