namespace FactoryClasses{
    public class Platinum : ICreditCard
    {
        int ICreditCard.GetAnnualCharge()
        {
           return 3500;
        }

        string ICreditCard.GetCardType()
        {
            return "Platinum Edge";
        }

        int ICreditCard.GetCreditLimit()
        {
            return 55000;
        }
    }
}