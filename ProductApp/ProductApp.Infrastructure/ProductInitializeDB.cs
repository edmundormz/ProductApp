using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Core;
using System.Data.Entity;

namespace ProductApp.Infrastructure
{
    public class ProductInitalizeDB : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product { Id = 1, Name = "Rice", inStock = true, Price = 30 });
            context.Products.Add(new Product { Id = 2, Name = "Sugar", inStock = false, Price = 40 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}