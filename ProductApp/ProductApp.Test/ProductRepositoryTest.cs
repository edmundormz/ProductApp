using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductApp.Infrastructure;
using System.Linq;

namespace ProductApp.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository Repo;

        [TestInitialize]
        public void TestSetup()
        {
            ProductInitalizeDB db = new ProductInitalizeDB();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new ProductRepository();
        }

        [TestMethod]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
            var result = Repo.GetProducts();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }
    }
}
