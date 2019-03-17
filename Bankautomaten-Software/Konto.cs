namespace Bankautomaten_Software
{
    public class Konto
    {

        private double balance;
        public Konto(double balance)
        {
            this.Balance = balance;

        }

        public double Balance { get => balance; set => balance = value; }

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