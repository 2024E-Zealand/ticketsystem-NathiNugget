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
        [DataRow(false, 29)]
        [DataRow(false, 28)]
        
        public void PriceTestNoBizz(bool brobizz, int day)
        {
            _car.Date = new DateTime(2024, 9, day);

            double expected = 410;
            double actual = _car.Price(brobizz);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(true)]
        public void PriceTestBroBizz(bool brobizz)
        {
            double expected = 161; 
            double actual = _car.Price(brobizz);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(true, 29)]
        [DataRow(true, 28)]
        public void PriceTestBroBizz(bool brobizz, int day)
        {
            double expected = 161; 
            double actual = _car.Price(brobizz);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "Oresund car";
            string actual = _car.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("12345678")]
        [DataRow(null)]
        public void LicenseplateIllegalTest(string number)
        {
            Assert.ThrowsException<ArgumentException>(() => { _car.Licenseplate = number; }); 

        }

        [TestMethod()]
        [DataRow("1234567")]
        
        public void Licenseplate(string number)
        {
            string expected = number;
            _car.Licenseplate = number;
            Assert.AreEqual(expected, _car.Licenseplate);

        }


        [TestMethod]
        [DataRow(29)]
        public void TestVehicleDate(int day)
        {
            _car.Date = new DateTime(2024, 9, day);
            Assert.IsNotNull(_car.Date);
        }

    }
}