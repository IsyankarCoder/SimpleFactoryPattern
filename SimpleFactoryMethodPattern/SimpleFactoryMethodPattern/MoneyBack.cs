namespace FactoryClasses{
    public class MoneyBack : ICreditCard
    {
        int ICreditCard.GetAnnualCharge()
        {
           return 15000;
        }

        string ICreditCard.GetCardType()
        {
            return "Money Back";
        }

        int ICreditCard.GetCreditLimit()
        {
            return 95000;
        }
    }
}