using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System;
using TallyBakery.Application.Core.Entities;
using TallyBakery.Application.Core.Interfaces;
using TallyBakery.Application.Persistence;
using Microsoft.Extensions.Logging;
using TallyBakery.Application.Core.Products.Interfaces;

namespace TallyBakery.Application.Core.Products.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ITallyBakeryDbContext dbContext;
        private readonly IQueryable<Product> products;
        private readonly IPriceBreakServices priceBreakServices;

        public ProductServices(ITallyBakeryDbContext dbContext, ILogger<ProductServices> logger,            
            IPriceBreakServices priceBreakServices)
        {
            this.dbContext = dbContext;
            this.products = this.dbContext.GetProducts() as IQueryable<Product>;
            this.priceBreakServices = priceBreakServices;
        }

        public ProductCart GetCartProduct(string code, int qty)
        {
            var productByCode = this.products.FirstOrDefault(f => f.code == code);
            if (productByCode == null)
                throw new ArgumentNullException($"{nameof(code)} is not the collection");

            var cheapestPriceBreak = this.priceBreakServices.GetCheapestPriceBreaks(qty, productByCode.priceBreaks.OrderByDescending(x => x.qty).ToList());

            var cartProduct = new ProductCart
            {
                Code = code,
                Qty = qty,
                Total = cheapestPriceBreak.Sum(x => x.multiply * x.price),
                PriceBreaks = cheapestPriceBreak
            };

            return cartProduct;
        }
    }
}