namespace Bankautomaten_Software
{
    public class Pin
    {
        public Pin()
        {
        }

        public bool checkBordersOfPin(int value)
        {
            return value >= 1000 && value <= 9999;
        }

    }
}