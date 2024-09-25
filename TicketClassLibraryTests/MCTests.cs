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
        public void PriceTest()
        {
            double expected = 125;
            double actual = _mc.Price(); 
        }

        [TestMethod()]
        public void VehicleTest()
        {
            string expected = "MC"; 
            string actual = _mc.VehicleType();
        }
    }
}