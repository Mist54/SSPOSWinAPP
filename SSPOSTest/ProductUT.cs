using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SSPOS.BLL;

namespace SSPOSTest
{
    [TestClass]
    public class ProductUT
    {
        [TestMethod]
        public void Test_RetrieveByID_ReturnsCorrectProduct()
        {
            //Arrage 
            int productId = 1;
            string Username = "sa";
            //Act
            Product product = Product.RetrieveByID(Username, productId);

            //Assert
            Assert.IsNotNull(product, "Product retrived");

        }

        [TestMethod]
        public void Test_RetriveAll_ReturnsListofProduct()
        {
            //Arrage
            string Username = "sa";
            //Act
            var lstproduct = Product.RetrieveAll(Username);

            //Assert
            Assert.IsNotNull(lstproduct, "Retrived the list");
            Assert.IsTrue(lstproduct.Count > 0, "The count of list is more than zero");
        }

        [TestMethod]
        public void Test_DeleteProductById_returnsTrue()
        {
            //Arrage
            int prdId = 1;
            string Username = "sa";
            //Act
            bool result = Product.DeleteProductById(Username,prdId);

            //Assert
            Assert.IsTrue(result, "Product deleted");

        }
    }
}
