using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Core.Entities;

namespace TallyBakery.Application.Core.Interfaces
{
    public interface IProductServices
    {        
        ProductCart GetCartProduct(string code, int qty);
    }
}
