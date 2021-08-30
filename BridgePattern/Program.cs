using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Create Refined Abstraction
            var customers = new Customers();

            //Set ConcreteImplementor
            customers.Data=new CustomersData("Chicago");

            //Exercise the Bridge Pattern
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henr gonzalae");


            customers.ShowAll();

            //Wait for user
            Console.ReadKey();


        }
    }
}
