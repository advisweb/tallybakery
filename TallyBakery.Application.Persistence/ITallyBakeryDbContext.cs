using System;
using System.Collections.Generic;
using System.Linq;

namespace TallyBakery.Application.Persistence
{
    public interface ITallyBakeryDbContext
    {
        IQueryable GetProducts();

        void UseFilename(string filename);
    }
}
