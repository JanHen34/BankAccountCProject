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
        Pin pin;

        [TestInitialize]
        public void init()
        {
            pin = new Pin(1234);
        }

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


        [TestMethod()]
        public void pinAccess_success()
        {
            Assert.IsTrue(pin.checkPin(1234));
        }


        [TestMethod()]
        public void pinAccess_fail()
        {
            Assert.IsFalse(pin.checkPin(1243));
        }


        [TestMethod()]
        public void pinAccess_failEvenAfterSuccess()
        {
            Assert.IsFalse(pin.checkPin(1243));
            Assert.IsFalse(pin.checkPin(1243));
            Assert.IsFalse(pin.checkPin(1243));
            //type the right pin and still get false, because we don´t have enough tries
            Assert.IsFalse(pin.checkPin(1234));
        }

        [TestMethod()]
        public void pinAccess_trueEvenSuccess()
        {
            Assert.IsFalse(pin.checkPin(1243));
            Assert.IsFalse(pin.checkPin(1243));
            //Resets the tries
            Assert.IsTrue(pin.checkPin(1234));

            Assert.IsFalse(pin.checkPin(1243));
            //Resets was successful
            Assert.IsTrue(pin.checkPin(1234));

        }
    }
}