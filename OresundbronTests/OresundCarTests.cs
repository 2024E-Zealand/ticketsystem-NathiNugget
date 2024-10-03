using Oresundbron;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Oresundbron.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class OresundCarTests
    {
        private OresundCar c;

        [TestInitialize]
        public void Setup()
        {
            c = new OresundCar("0000000", DateTime.Today);
        }
        [TestMethod]
        public void TestNewMC()
        {
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "Oresund car";
            string actual = c.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceTest()
        {
            double expected = 410;
            double actual = c.Price(false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void PriceTestTrue()
        {

            double expected = 210;
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