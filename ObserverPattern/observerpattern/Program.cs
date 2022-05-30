using System;
using ObserverPatternClasses;
using System.Collections.Generic;
using System.Collections;

namespace observerpattern
{
    class Program
    {
        static void Main(string[] args)
        {
           Subject subject =new Subject("Red MI Mobile",10000,"Out of Stock");

           Observer user1 = new Observer("Volkan",subject);
           Observer user2 =new Observer("Sude",subject);
           Observer user3=new Observer("Gonca",subject);

            Console.WriteLine("Red MI Mobile current state : " + subject.getAvailability());
            Console.WriteLine();
            // Now product is available
            subject.SetAvailability("Available");
            Console.Read();


        }
    }
}

namespace  ObserverPatternClasses
{
     public interface ISubject
    { 
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();        
    }

    public class Subject:ISubject
    {
         public List<IObserver> observers=new List<IObserver>();
         private string ProductName{get;set;}
         private int ProductPrice{get;set;}
             public string Availability{get;set;}
              public Subject(string productName,int productPrice,string availability){
                  this.ProductName= productName;
                  this.ProductPrice = productPrice;
                  this.Availability = availability;                  
              }

     public void RegisterObserver(IObserver observer){
         observers.Add(observer);
     }
     public  void RemoveObserver(IObserver observer){
         observers.Remove(observer);
     }
     public string getAvailability(){
         return this.Availability;
     }

     public void SetAvailability(string availability){
                this.Availability=availability;
                Console.WriteLine("Availability changed from Out of Stock to Available.");
                NotifyObservers();
     }
      
     public void NotifyObservers(){
          Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.update(Availability);
            }
     }
    
    }
     
     public interface IObserver
     {
          void update(string availability);
         
     }

     public class Observer:IObserver{
          public string UserName{get;set;}

          public Observer(string userName,ISubject subject){
              UserName=userName;
              subject.RegisterObserver(this);
          }
          public void update(string availability){
              Console.WriteLine($"hello baby {this.UserName} Product is {availability} on Amazon");
          }
           
     }
      
}
