using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProductApp.Infrastructure
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=ProductAppConnectionString") { }
        public DbSet Products { get; set; }
    }
}
