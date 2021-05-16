using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TallyBakery.Application.Persistence
{
    public class TallyBakeryDbContext<T> : ITallyBakeryDbContext
    {
        private List<T> Products { get; set; }
        public IQueryable GetProducts() { return this.Products.AsQueryable(); }       

        public TallyBakeryDbContext()
        {
            Products = new List<T>();
        }

        private void InitializeCollection(string data)
        {
            this.Products = JsonConvert.DeserializeObject<List<T>>(data);
        }

        public void UseFilename(string filename)
        {
            var path = $"{Directory.GetCurrentDirectory()}/{filename}";
            var data = File.ReadAllText(path);
            this.InitializeCollection(data);
        }
    }
}
