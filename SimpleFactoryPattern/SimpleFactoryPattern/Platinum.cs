namespace SimpleFactoryPattern.CarManager
{
    public class Platinum : ICreditCard
    {
        int ICreditCard.GetAnnualCharge()
        {
               return 2000;
        }

        string ICreditCard.GetCardType()
        {
            return "Platinum Plus";
        }

        int ICreditCard.GetCreditLimit()
        {
             return 35000;
        }
    }
}