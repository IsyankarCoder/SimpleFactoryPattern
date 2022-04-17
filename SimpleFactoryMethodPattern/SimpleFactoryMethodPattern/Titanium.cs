namespace FactoryClasses{
    public class Titanium : ICreditCard
    {
        int ICreditCard.GetAnnualCharge()
        {
           return 1500;
        }

        string ICreditCard.GetCardType()
        {
            return "Titanium Edge";
        }

        int ICreditCard.GetCreditLimit()
        {
            return 25000;
        }
    }
}