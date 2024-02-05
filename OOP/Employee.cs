using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee : Person
{
    protected int NINumber;
    public Employee(string name, string address, int ninumber) : base(name, address)
    {
        NINumber = ninumber;
    }

    public void SetNiNumber(int newnumber)
    {
        NINumber = newnumber;
    }

    public void OutputNiNumber() 
    {
        Console.WriteLine(NINumber);
    }

    public static void EmployeeTests()
    {
        Employee employee1 = new Employee("dave", "london", 1551);
        //Console.WriteLine(employee1.GetName());
        //Console.WriteLine(employee1.GetAddress());
        //employee1.OutputNiNumber();

        employee1.SetNiNumber(1552);

        //employee1.OutputNiNumber();

        HourlyPaidEmp emp2 = new HourlyPaidEmp("john", "bath", 100, 15.0);

        SalariedEmp emp3 = new SalariedEmp("jane", "bristol", 100, 10000);

        List<Employee> employees = new List<Employee>();

        employees.Add(emp2);
        employees.Add(emp3);

        foreach (Employee emp in employees)
        {
            //Console.WriteLine(emp.GetName());

            emp.OutputName();

            if (emp is SalariedEmp)
            {
                SalariedEmp salariedEmp = (SalariedEmp)emp;
                salariedEmp.OutputSalary();
            }
        }

    }

}

