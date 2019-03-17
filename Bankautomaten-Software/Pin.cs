namespace Bankautomaten_Software
{
    public class Pin
    {
        private int pin;
        private int tries;

        public Pin(int pin)
        {
            this.pin = pin;
            this.tries = 3;
        }

        public bool checkBordersOfPin(int value)
        {
            return value >= 1000 && value <= 9999;
        }

        public bool checkPin(int typedPin)
        {
            if(pin == typedPin && this.tries > 0)
            {
                this.tries = 3;
                return true;
            }
            else
            {
                tries--;
                return false;
            }
        }

    }
}