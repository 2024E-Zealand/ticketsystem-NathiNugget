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
            c = new Car("0000000", DateTime.Now);
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
            double actual = c.Price();
            Assert.AreEqual(expected, actual);
        }
    }
}