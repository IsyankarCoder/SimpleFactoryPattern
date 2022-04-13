
namespace SimpleFactoryPattern.CarManager{

public interface ICreditCard{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}
}