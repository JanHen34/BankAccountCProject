using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomaten_Software
{
    class Program
    {
        static int pin;
        static string eingabe;       
        static string währung = "Euro";
        static double kontostand = 1000;
        static string bearbeitung_fortsetzen;       
        static double betrag_einzahlen;
        static double betrag_auszahlen;
   
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei der Sparkasse!");
            Console.WriteLine("Bitte geben sie Ihre 4 stelligen PIN ein um fortzufahren!");
            pin = Convert.ToInt32(Console.ReadLine());
            //1,2,3,4..... >||1111,11112,1113..... 9998,9999||< 10000
            while (pin < 1111 || pin > 9999)
            {
                pin = pinUeberpruefung(pin);              
            }

            Console.WriteLine("Bitte wähen Sie aus den 3 Möglichkeiten: Einzahlen, Auszahlen und Kontostand aus!");
            eingabe = Console.ReadLine();
            starteBankProzess();
            Console.WriteLine("Wollen Sie die Bearbeitung fortsetzen?");
            bearbeitung_fortsetzen = Console.ReadLine();
            while (bearbeitung_fortsetzen == "Ja")
            {
                Console.WriteLine("Bitte wählen Sie aus den 3 Möglichkeiten: Einzahlen, Auszahlen und Kontostand aus!");
                eingabe = Console.ReadLine();
                starteBankProzess();
                Console.WriteLine("Wollen sie die Bearbeitung fortsetzen?");
                bearbeitung_fortsetzen = Console.ReadLine();
                if (bearbeitung_fortsetzen == "Nein")
                {
                    break;
                }
            }
            Console.WriteLine("Wir wünschen Ihnen noch einen schönen Tag! Bitte drücken Sie eine Taste!");
            Console.ReadKey();
        }

        private static void starteBankProzess()
        {
            switch (eingabe)
            {
                case "Einzahlen":
                    starteEinzahlen();
                break;
                case "Auszahlen":
                    starteAuszahlen();
                break;
                case "Kontostand":
                    Console.WriteLine("Ihr Kontostand beträgt " + kontostand + " " + währung + ".");
                break;
            }
        }

        private static void starteAuszahlen()
        {
            Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie auszahlen möchten.");
            betrag_auszahlen = Convert.ToDouble(Console.ReadLine());
            berechnungAuszahlen();
            Console.WriteLine("Ihr Kontostand wurde aktualisiert. Bitte entnehmen Sie ihr Geld!");
        }

        private static double berechnungAuszahlen()
        {
            return kontostand = kontostand - betrag_auszahlen;
        }

        private static void starteEinzahlen()
        {
            Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie einzahlen möchten.");
            betrag_einzahlen = Convert.ToDouble(Console.ReadLine());
            berechnungEinzahlen();
            Console.WriteLine("Ihr Kontostand wurde Aktualisiert. Bitte Sie Ihr einzuzahlendes Geld in die Vorrichtung!");
        }

        private static double berechnungEinzahlen()
        {
            return kontostand = kontostand + betrag_einzahlen;
        }

        static int pinUeberpruefung(int pin)
        {           
            Console.WriteLine("Die angegebene PIN einspricht nicht den Anforderungen! Bitte geben sie ihre PIN erneut ein!");
            pin = Convert.ToInt32(Console.ReadLine());
            return pin;
        }
      
        

       
    }
}

