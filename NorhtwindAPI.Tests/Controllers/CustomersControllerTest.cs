using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorhtwindAPI;
using NorhtwindAPI.Controllers;
using NorthwindDataAccess;

namespace NorhtwindAPI.Tests.Controllers
{
    [TestClass]
    public class CustomersControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
               CustomersController controller = new CustomersController();

            // Act
               CustomersView testOne = controller.Get("ALFKI");
               IEnumerable<CustomerOrder> testTwo = controller.orders("ALFKI");
            // Test One
                Assert.IsNotNull(testOne);
                Assert.AreEqual("Berlin", testOne.City);
            // Test Two
            Assert.IsNotNull(testTwo);
            Assert.AreEqual("Errors migh arise with this order", testTwo.First().Message);

        }
    }
}
