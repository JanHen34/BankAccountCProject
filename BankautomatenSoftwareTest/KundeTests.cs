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
    public class KundeTests
    {
        Kunde kunde;

        [TestInitialize]
        public void init()
        {
            kunde = new Kunde("Lars", "Larsen");
        }

        [TestMethod()]
        public void KundeTest()
        {
            Assert.IsNotNull(kunde);
        }

        [TestMethod()]
        public void getFullNameTest()
        {
            Assert.AreEqual("Lars Larsen", kunde.getFullName());
        }
    }
}