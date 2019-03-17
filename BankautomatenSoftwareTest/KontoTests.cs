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
    public class KontoTests
    {
        Konto konto;

        [TestInitialize]
        public void testInit()
        {
            konto = new Konto(1000);
        }

        [TestMethod()]
        public void KontoTest()
        {
            Assert.IsNotNull(konto);
        }

        [TestMethod()]
        public void addBalanceTest()
        {
            konto.addBalance(100);
            Assert.AreEqual(1100,konto.Balance);
        }

        [TestMethod()]
        public void removeBalanceTest()
        {
            konto.removeBalance(100);
            Assert.AreEqual(900,konto.Balance);
        }
    }
}