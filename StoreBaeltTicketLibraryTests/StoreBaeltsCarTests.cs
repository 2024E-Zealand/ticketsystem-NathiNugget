using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class StoreBaeltsCarTests
    {
        private StoreBaeltsCar smc;

        [TestInitialize]
        public void Setup()
        {
            smc = new StoreBaeltsCar("0000000", DateTime.Today);
        }
        [TestMethod]
        public void TestNewMC()
        {
            Assert.IsNotNull(smc);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "StoreBaeltsCar";
            string actual = smc.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceTest()
        {
            double expected = 240;
            double actual = smc.Price(false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(5)]
        [DataRow(6)]
        public void PriceTestTrue(int day)
        {
            smc = new StoreBaeltsCar("0000000", new DateTime(2024, 10, day)); 
            double expected = 240 * 0.95;
            expected *= 0.8; 
            double actual = smc.Price(true);
            Assert.AreEqual(expected, actual, 0.00001);
        }

        [TestMethod]
        public void TestLicenseplate()
        {
            string expected = "0000000";
            string actual = smc.Licenseplate;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDateTime()
        {
            DateTime expected = DateTime.Today;
            DateTime actual = smc.Date;
            Assert.AreEqual(expected, actual);
        }
    }
}