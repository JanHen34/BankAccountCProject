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
        static bool pin_anforderung;
        static string eingabe;
        static string eingabe_2;
        static string währung = "Euro";
        static double kontostand = 1000;
        static string bearbeitung_fortsetzen;
        static string name_kunde;

        static double betrag_einzahlen;
        static double betrag_auszahlen;


        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei der Sparkasse!");
            Console.WriteLine("Bitte geben sie Ihre 4 stelligen PIN ein um fortzufahren!");
            pin = Convert.ToInt32(Console.ReadLine());

            //1,2,3,4..... >||1111,11112,1113..... 9998,9999||< 10000
            while (pin < 1111 || pin > 9999 )
            {
                pin = pinUeberpruefung();
                Console.WriteLine("test code");
            }

            ichSchreibeEineNeueMethode(kontostand);

            Console.WriteLine("Bitte wähen Sie aus den 3 Möglichkeiten: Einzahlen, Auszahlen und Kontostand aus!");
            eingabe = Console.ReadLine();
            starteBankProzess(eingabe, währung, kontostand);
            Console.WriteLine("Wollen Sie die Bearbeitung fortsetzen?");
            bearbeitung_fortsetzen = Console.ReadLine();
            while (bearbeitung_fortsetzen == "Ja")
            {
                Console.WriteLine("Bitte wählen Sie aus den 3 Möglichkeiten: Einzahlen, Auszahlen und Kontostand aus!");
                eingabe = Console.ReadLine();
                starteBankProzess(eingabe, währung, kontostand);
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

        private static void ichSchreibeEineNeueMethode(double kontostand)
        {
            Console.WriteLine("yolo");
        }

        private static int pinUeberpruefung()
        {
            int pin;
            Console.WriteLine("Die angegebene PIN einspricht nicht den Anforderungen! Bitte geben sie ihre PIN erneut ein!");
            pin = Convert.ToInt32(Console.ReadLine());
            return pin;
        }

        private static void starteBankProzess(string eingabe, string währung, double kontostand)
        {
            switch (eingabe)
            {
                case "Einzahlen":
                    starteEinzahlen(kontostand);
                    break;
                case "Auszahlen":
                    starteAuszahlen(kontostand);
                    break;
                case "Kontostand":
                    Console.WriteLine("Ihr Kontostand beträgt " + kontostand + " " + währung + ".");
                    break;
            }
        }

        private static double starteAuszahlen(double kontostand)
        {
            double betrag_auszahlen;
            Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie auszahlen möchten.");
            betrag_auszahlen = Convert.ToDouble(Console.ReadLine());
            kontostand = fuehreAuzahleAus(kontostand, betrag_auszahlen);
            Console.WriteLine("Ihr Kontostand wurde aktualisiert. Bitte entnehmen Sie ihr Geld!");
            return betrag_auszahlen;
        }

        private static double starteEinzahlen(double kontostand)
        {
            double betrag_einzahlen;
            Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie einzahlen möchten.");
            betrag_einzahlen = Convert.ToDouble(Console.ReadLine());
            kontostand = fuehreEinzahlenAus(kontostand, betrag_einzahlen);
            Console.WriteLine("Ihr Kontostand wurde Aktualisiert. Bitte Sie Ihr einzuzahlendes Geld in die Vorrichtung!");
            return betrag_einzahlen;
        }

        static double fuehreEinzahlenAus(double kontostand, double betrag_einzahlen)
        {
            return kontostand = kontostand + betrag_einzahlen;
        }

        static double fuehreAuzahleAus(double betrag_auszahlen, double kontostand)
        {               
            return kontostand = kontostand - betrag_auszahlen;          
        }
    }
}

