using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TallyBakery.Application.Core
{
    public class ProductRepository{
        public List<Product> ProductCollection { get; set; }
        public ProductRepository()
        {
            
        }

        public void Initialization(){
            var data = File.ReadAllText("~/db.json");
            this.ProductCollection = JsonConvert.DeserializeObject<List<Product>>(data);
        }

        public void GetCheapestPriceBreaks(string code, int qty){
            var productByCode = this.ProductCollection.FirstOrDefault(f => f.code == code);
            if(productByCode == null)
                throw new ArgumentNullException($"{nameof(code)} is not the collection");

            var priceBreaks = this.GetMaxPriceBreakByProduct(code, qty);
            //qty % ()
            //productByCode
        }

        public void GetMaxPriceBreakByProduct(string code, int qty){
            var productByCode = this.ProductCollection.FirstOrDefault(f => f.code == code);
            if(productByCode == null)
                throw new ArgumentNullException($"{nameof(code)} is not the collection");

            productByCode.priceBreaks.ToList()
            .ForEach(f=>{
                var qtyMod = qty % f.qty;
                if(qtyMod < f.qty)
                {
                    qty = qtyMod;
                    //store the price bracket
                }
            });
        }
    }
}