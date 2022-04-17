using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello World!");
          Singleton sd = Singleton.GetInstance;
          sd.PrintDetails("Form aa");
          Singleton sb =Singleton.GetInstance;
          sb.PrintDetails("Form vv");
          Console.ReadLine();
          
        }
    }
}
