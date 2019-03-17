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
            string währung = "Euro";
            double kontostand = 1000;

            Konto konto = generateUserForBankSystem(kontostand);

            checkPin(konto);
            string eingabe;
            string bearbeitung_fortsetzen;

            do
            {
                Console.WriteLine("Bitte wählen Sie aus den 3 Möglichkeiten: Einzahlen, Auszahlen und Kontostand aus!");
                eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "Kontostand":
                        readKonto(währung, konto);
                        break;
                    case "Einzahlen":
                        addBalanceToKonto(konto);
                        break;
                    case "Auszahlen":
                        removeBalanceFromKonto(konto);
                        break;
                }
                Console.WriteLine("Wollen sie die Bearbeitung fortsetzen?");
                bearbeitung_fortsetzen = Console.ReadLine();
            } while ("ja".Equals(bearbeitung_fortsetzen.ToLower()) || "j".Equals(bearbeitung_fortsetzen));

            Console.WriteLine("Wir wünschen Ihnen noch einen schönen Tag! Bitte drücken Sie eine Taste!");
            Console.ReadKey();


        }

        private static Konto generateUserForBankSystem(double kontostand)
        {
            Kunde kunde = new Kunde("Vorname", "Nachname");
            Pin pin = new Pin(1234);
            Konto konto = new Konto(kunde, pin, "kontoNummer", kontostand);
            return konto;
        }

        /*
         * reads the actual balance from the account
         * 
         */
        private static void readKonto(string währung, Konto konto)
        {
            Console.WriteLine("Ihr Kontostand beträgt " + konto.Balance + " " + währung + ".");
        }

        /*
         * removes money from the account
         * 
         */
        private static void removeBalanceFromKonto(Konto konto)
        {
            int betrag_auszahlen;
            Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie auszahlen möchten.");
            betrag_auszahlen = Convert.ToInt32(Console.ReadLine());
            konto.removeBalance(betrag_auszahlen);
            Console.WriteLine("Ihr Kontostand wurde aktualisiert. Bitte entnehmen Sie ihr Geld!");
        }

        /*
         * Add money into the account
         */
        private static void addBalanceToKonto(Konto konto)
        {
            int betrag_einzahlen;
            Console.WriteLine("Bitte geben sie den gewünschten Betrag ein, den sie einzahlen möchten.");
            betrag_einzahlen = Convert.ToInt32(Console.ReadLine());
            konto.addBalance(betrag_einzahlen);
            Console.WriteLine("Ihr Kontostand wurde Aktualisiert. Bitte Sie Ihr einzuzahlendes Geld in die Vorrichtung!");
        }

        private static int checkPin(Konto konto)
        {
            
            Console.WriteLine("Willkommen bei der Sparkasse!");
            Console.WriteLine("Bitte geben sie Ihre 4 stelligen PIN ein um fortzufahren!");
            
            int pin;
            pin = Convert.ToInt32(Console.ReadLine());

            Pin pinCheck = konto.Pin;
            while (!pinCheck.checkBordersOfPin(pin))
            {
                Console.WriteLine("Die angegebene PIN einspricht nicht den Anforderungen! Bitte geben sie ihre PIN erneut ein!");
                pin = Convert.ToInt32(Console.ReadLine());
            }

            return pin;
        }
    }
}
