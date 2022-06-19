using System;

namespace IocDip
{
    class Program
    {
        static void Main(string[] args)
        {

            IocDip.EmployeeBusinessLogic a =new EmployeeBusinessLogic(new EmployeeDataAccess());
            var emp =  a.GetEmployeeDetails(1);
            Console.WriteLine($"Name = {emp.Name}");
           
        }
    }
}
