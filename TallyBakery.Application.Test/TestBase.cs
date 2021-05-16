using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Persistence;
using TallyBakery.Application.Test.Infrastructure;

namespace TallyBakery.Application.Test
{
    public class TestBase
    {
        protected ITallyBakeryDbContext context;
        public TestBase()
        {
            context = FilebaseContext.CreateContext();
        }
    }
}
