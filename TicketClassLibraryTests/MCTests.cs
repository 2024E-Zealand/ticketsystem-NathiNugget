using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;

namespace TicketClassLibrary.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class MCTests
    {
        private MC mc;

        [TestInitialize]
        public void Setup()
        {
            mc = new MC("0000000", DateTime.Today);
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
            double actual = mc.Price(false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceTestTrue()
        {
            double expected = 125*0.95;
            double actual = mc.Price(true);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLicenseplate()
        {
            string expected = "0000000";
            string actual = mc.Licenseplate; 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDateTime()
        {
            DateTime expected = DateTime.Today;
            DateTime actual = mc.Date; 
            Assert.AreEqual(expected, actual);
        }
    }
}