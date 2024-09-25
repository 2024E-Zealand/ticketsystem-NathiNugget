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
    public class MCTests
    {
        private MC _mc; 
        [TestInitialize]
        public void Setup()
        {
            _mc = new MC();
        }

        [TestMethod()]
        [DataRow(true)]
        public void PriceTestBroBizz(bool brobizz)
        {
            double expected = 73;
            double actual = _mc.Price(brobizz);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(false)]
        public void PriceTestNoBizz(bool brobizz)
        {
            double expected = 210; 
            double actual = _mc.Price(brobizz); 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            string expected = "Oresund MC"; 
            string actual = _mc.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("12345678")]
        public void LicenseplateIllegalTest(string number)
        {
            Assert.ThrowsException<ArgumentException>(() => { _mc.Licenseplate = number; });

        }
    }
}