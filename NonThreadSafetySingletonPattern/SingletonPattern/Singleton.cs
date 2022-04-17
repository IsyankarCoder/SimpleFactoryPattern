using System;

namespace SingletonPattern
{
     public sealed class Singleton{
         private static int counter = 0;
         private static Singleton instance = null;

         public static Singleton GetInstance{
             get{
                 if(instance==null)
                  instance =new Singleton();
                  return instance;
             }
         }

          static Singleton(){
              Console.WriteLine("Static Cons");

        }
         private Singleton(){
             counter++;
             Console.WriteLine($"Counter Value {counter.ToString()}");
         }
         
         public void PrintDetails(string message){
             Console.WriteLine(message);
         }

     }
}