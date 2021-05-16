using NUnit.Framework;
using TallyBakery.Application.Core.Products.Services;
using System.Linq;
using TallyBakery.Application.Core.Entities;

namespace TallyBakery.Application.Test
{
    [TestFixture]
    public class PriceBreakTest : TestBase
    {

        [TestCase(10, "VS5")]
        [TestCase(13, "CF")]
        [TestCase(14, "MB11")]
        [Test]
        public void Wil_Return_Cheapest_Package(int cartQty, string productCode)
        {
            var products = context.GetProducts() as IQueryable<Product>;
            var priceBreaks = products.Where(p => p.code == productCode).FirstOrDefault().priceBreaks;

            PriceBreakServices services = new PriceBreakServices();
            var cheapest = services.GetCheapestPriceBreaks(cartQty, priceBreaks);
            //context.GetProducts()
            Assert.IsTrue(cheapest.Count > 0);
        }

        [TestCase(17, "VS5")]
        [TestCase(11, "MB11")]
        [TestCase(19, "CF")]        
        [Test]
        public void Will_NOT_Return_Any_Package(int cartQty, string productCode)
        {
            var products = context.GetProducts() as IQueryable<Product>;
            var priceBreaks = products.Where(p => p.code == productCode).FirstOrDefault().priceBreaks;

            PriceBreakServices services = new PriceBreakServices();
            var cheapest = services.GetCheapestPriceBreaks(cartQty, priceBreaks);
            //context.GetProducts()
            Assert.IsTrue(cheapest.Count == 0);
        }
    }
}