using System;
using FactoryClasses;

namespace SimpleFactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           ICreditCard creditCard =new PlatinumFactory().CreateProduct();
           if(creditCard!=null){
               Console.WriteLine("Card Type : "+creditCard.GetCardType());
               Console.WriteLine("Credit Limit : "+creditCard.GetCreditLimit());
               Console.WriteLine("Annual Charge : "+ creditCard.GetAnnualCharge());
           }
           else{
               Console.Write("Invalid Card Type");
           }
           Console.WriteLine("-------------------------");

           creditCard=new MoneyBackFactory().CreateProduct();
            if(creditCard!=null){
               Console.WriteLine("Card Type : "+creditCard.GetCardType());
               Console.WriteLine("Credit Limit : "+creditCard.GetCreditLimit());
               Console.WriteLine("Annual Charge : "+ creditCard.GetAnnualCharge());
           }
           else{
               Console.Write("Invalid Card Type");
           }
        }
    }
}
