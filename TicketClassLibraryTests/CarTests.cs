using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace TicketClassLibrary.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class CarTests
    {
        private Car c;

        [TestInitialize]
        public void Setup()
        {
            c = new Car("0000000", DateTime.Today);
        }
        [TestMethod]
        public void TestNewCar()
        {
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "Car";
            string actual = c.VehicleType(); 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceTest()
        {
            double expected = 240; 
            double actual = c.Price(false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceTestTrue()
        {
            double expected = 240*0.95;
            double actual = c.Price(true);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLicenseplate()
        {
            string expected = "0000000";
            string actual = c.Licenseplate;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDateTime()
        {
            DateTime expected = DateTime.Today;
            DateTime actual = c.Date; 
            Assert.AreEqual(expected, actual);
        }
    }
}