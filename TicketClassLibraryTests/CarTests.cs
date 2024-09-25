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
        private Car _car;

        [TestInitialize]
        public void Setup()
        {
            _car = new Car();
        }

        [TestMethod()]
        [DataRow(false)]
        public void PriceTestNoBizz(bool brobizz)
        {
            double expected = 240;
            double actual = _car.Price(brobizz);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(true)]
        public void PriceTestBroBizz(bool brobizz)
        {
            double expected = 240 * 0.95;
            double actual = _car.Price(brobizz);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "Car";
            string actual = _car.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("12345678")]
        public void LicenseplateIllegalTest(string number)
        {
            Assert.ThrowsException<ArgumentException>(() => { _car.Licenseplate = number; }); 

        }
    }
}