using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

             Garage car = new Garage(2,4, "tesla");

             // Console.WriteLine(car.EngineSize);
             Console.WriteLine(car.GetNumWheels());


             Console.WriteLine(car.SetNumWheels(5));
             Console.WriteLine(car.GetNumWheels());

             Console.WriteLine(car.EngineSize);

             try
             {
                 car.EngineSize -= 5;
             }
             catch (ArgumentOutOfRangeException a) 
             { 
                 Console.WriteLine("car.EngineSize-=5, not an acceptable engine size"); 
             } 


             Console.WriteLine(car.EngineSize);

            //Person.PersonTests();

            //Lightbulb.BulbTests();

            Employee.EmployeeTests();

            //HourlyPaidEmp.HourlyPaidEmpTests();

            //SalariedEmp.SalariedEmpTests();


        }
    }
}
