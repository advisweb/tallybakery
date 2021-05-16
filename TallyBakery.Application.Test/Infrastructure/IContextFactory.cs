using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Persistence;

namespace TallyBakery.Application.Test.Infrastructure
{
    public interface IContextFactory
    {
        public static ITallyBakeryDbContext CreateContext;
    }
}
