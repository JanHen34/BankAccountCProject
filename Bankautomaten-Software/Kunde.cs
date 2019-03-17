namespace Bankautomaten_Software
{
    public class Kunde
    {
        private string foreName;
        private string lastName;

        public Kunde(string foreName, string lastName)
        {
            this.foreName = foreName;
            this.lastName = lastName;
        }

        public string getFullName()
        {
            return foreName + " " + lastName;
        }
    }
}