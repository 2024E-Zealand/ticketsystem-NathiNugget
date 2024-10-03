using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class OresundMCTests
    {
        private OresundMC mc;

        [TestInitialize]
        public void Setup()
        {
            mc = new OresundMC("0000000", DateTime.Today);
        }
        [TestMethod]
        public void TestNewMC()
        {
            Assert.IsNotNull(mc);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "Oresund MC";
            string actual = mc.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceTest()
        {
            double expected = 161;
            double actual = mc.Price(false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
       
        public void PriceTestTrue()
        {

            double expected = 73;
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