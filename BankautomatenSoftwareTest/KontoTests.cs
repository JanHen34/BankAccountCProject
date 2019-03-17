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
        Kunde kunde;
        Pin pin;

        [TestInitialize]
        public void testInit()
        {

            kunde = new Kunde("forName", "LastName");
            pin = new Pin(1234);
            konto = new Konto(kunde, pin, "1234513", 1000);
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

        [TestMethod()]
        public void getKunde()
        {
            Kunde result = konto.Kunde;
            Assert.AreEqual(kunde, result);
        }


        [TestMethod()]
        public void getPin()
        {
            Pin result = konto.Pin;
            Assert.AreEqual(pin, result);
        }

    }
}