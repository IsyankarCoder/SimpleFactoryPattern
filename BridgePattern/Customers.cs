using System;

namespace BridgePattern{
  
    public class Customers: CustomersBase{
        public override void ShowAll()
        {
            //Add Seperator lines
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            base.ShowAll();
            Console.WriteLine("----------------------------");
        }
    }
}