using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bankautomaten_Software;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomaten_Software.Tests
{
    [TestClass()]
    public class PinTests
    {
        Pin pin = new Pin();

        [TestMethod()]
        public void PinTest()
        {    
            Assert.IsNotNull(pin);
        }

        [TestMethod()]
        public void getLowerBorderTest_True()
        {
            Assert.IsTrue(pin.checkBordersOfPin(1000));
        }
        
        [TestMethod()]
        public void getUpperBorderTest_True()
        {
            Assert.IsTrue(pin.checkBordersOfPin(9999));
        }

        [TestMethod()]
        public void getUpperBorderTest_false()
        {
            Assert.IsFalse(pin.checkBordersOfPin(10000));
        }

        [TestMethod()]
        public void getLowerBorderTest_false()
        {
            Assert.IsFalse(pin.checkBordersOfPin(999));
        }
    }
}