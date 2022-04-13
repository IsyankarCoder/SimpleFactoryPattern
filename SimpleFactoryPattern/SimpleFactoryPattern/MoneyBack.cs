namespace SimpleFactoryPattern.CarManager{

    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        { 
            return 15000;
        }
    }
}