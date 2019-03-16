using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomaten_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin;
            bool pin_anforderung;
            string eingabe;
            string eingabe_2;
            string währung = "Euro";
            double kontostand = 1000;
            string bearbeitung_fortsetzen;
            string name_kunde;

            string test;
            Boolean tester = true;
            int betrag_einzahlen;
            int betrag_auszahlen;

            Console.WriteLine("Willkommen bei der Sparkasse!");
            Console.WriteLine("Bitte geben sie Ihre 4 stelligen PIN ein um fortzufahren!");            
            pin = Convert.ToInt32(Console.ReadLine());
            while (pin > 9999 == true)
            {
                Console.WriteLine("Die angegebene PIN einspricht nicht den Anforderungen! Bitte geben sie ihre PIN erneut ein!");
                pin = Convert.ToInt32(Console.ReadLine());              
            }
            while (pin < 1111 == true)
            {
                Console.WriteLine("Die angegebene PIN entspricht nicht den Anforderungen! Bitte geben sie Ihre PIN erneut ein!");
                pin = Convert.ToInt32(Console.ReadLine());                              
            }
            Console.WriteLine("Bitte wählen Sie aus den 4 Möglichkeiten: Einzahlen, Auszahlen und Kontostand aus!");
            eingabe = Console.ReadLine();
            switch (eingabe)
            {
                case "Einzahlen" :
                    Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie einzahlen möchten.");
                    betrag_einzahlen = Convert.ToInt32(Console.ReadLine());
                    kontostand = kontostand + betrag_einzahlen;
                    Console.WriteLine("Ihr Kontostand wurde Aktualisiert. Bitte Sie Ihr einzuzahlendes Geld in die Vorrichtung!");
                break;
                case "Auszahlen":
                    Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie auszahlen möchten.");
                    betrag_auszahlen = Convert.ToInt32(Console.ReadLine());
                    kontostand = kontostand - betrag_auszahlen;
                    Console.WriteLine("Ihr Kontostand wurde aktualisiert. Bitte entnehmen Sie ihr Geld!");
                break;
                case "Kontostand":
                    Console.WriteLine("Ihr Kontostand beträgt " + kontostand + " " + währung + ".");
                break;
            }
            Console.WriteLine("Wollen Sie die Bearbeitung fortsetzen?");
            bearbeitung_fortsetzen = Console.ReadLine();
            while (bearbeitung_fortsetzen == "Ja")
            {
                Console.WriteLine("Bitte wählen Sie aus den 3 Möglichkeiten: Einzahlen, Auszahlen und Kontostand aus!");
                eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "Kontostand":
                        Console.WriteLine("Ihr Kontostand beträgt " + kontostand + " " + währung + ".");
                    break;
                    case "Einzahlen":
                        Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie einzahlen möchten.");
                        betrag_einzahlen = Convert.ToInt32(Console.ReadLine());
                        kontostand = kontostand + betrag_einzahlen;
                        Console.WriteLine("Ihr Kontostand wurde Aktualisiert. Bitte Sie Ihr einzuzahlendes Geld in die Vorrichtung!");
                    break;
                    case "Auszahlen":
                        Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie auszahlen möchten.");
                        betrag_auszahlen = Convert.ToInt32(Console.ReadLine());
                        kontostand = kontostand - betrag_auszahlen;
                        Console.WriteLine("Ihr Kontostand wurde aktualisiert. Bitte entnehmen Sie ihr Geld!");
                    break;
                }
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
    }
}
