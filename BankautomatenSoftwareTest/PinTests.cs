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
        public void getUpperBorderTest()
        {

            Assert.IsTrue(pin.getUpperBorder());
        }
    }
}