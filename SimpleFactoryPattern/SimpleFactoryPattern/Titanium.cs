namespace SimpleFactoryPattern.CarManager
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
             return 1500;
        }

        public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}