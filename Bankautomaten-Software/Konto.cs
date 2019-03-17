namespace Bankautomaten_Software
{
    public class Konto
    {

        private double balance;
        private string accountNumber;
        private Kunde kunde;
        private Pin pin;

        public Konto(double balance)
        {
            this.Balance = balance;

        }

        public Konto(string accountNumber, double actualBalance)

        {
            this.AccountNumber = accountNumber;
            this.Balance = actualBalance;
        }

        public Konto(Kunde kunde, Pin pin, string acccountNumber, double balance)
        {
            this.Kunde = kunde;
            this.Pin = pin;
            this.AccountNumber = acccountNumber;
            this.Balance = balance;
        }

        public double Balance { get => balance; set => balance = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public Kunde Kunde { get => kunde; set => kunde = value; }
        public Pin Pin { get => pin; set => pin = value; }


        public void addBalance(double value)
        {
            Balance += value;
        }

        public void removeBalance(double value)
        {
            Balance -= value;
        }
    }
}