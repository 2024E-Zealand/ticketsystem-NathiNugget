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
        public void PriceTest()
        {
            double expected = 240;
            double actual = _car.Price(); 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            string expected = "Car"; 
            string actual = _car.VehicleType();
            Assert.AreEqual(expected, actual);
        }
    }
}