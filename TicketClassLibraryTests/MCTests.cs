using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        private MC mc;

        [TestInitialize]
        public void Setup()
        {
            mc = new MC();
        }
        [TestMethod]
        public void TestNewMC()
        {
            Assert.IsNotNull(mc);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "MC";
            string actual = mc.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceTest()
        {
            double expected = 125;
            double actual = mc.Price();
            Assert.AreEqual(expected, actual);
        }
    }
}