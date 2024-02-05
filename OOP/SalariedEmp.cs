using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class SalariedEmp : Employee
{
    private double Salary;
    public SalariedEmp(string name, string address, int ninumber, double salary) : base(name, address, ninumber)
    {
        Salary = salary;
    }

    public void OutputSalary()
    {
        Console.WriteLine(Salary);
    }
    public void SetSalary(double newsalary)
    {
        Salary = newsalary;
    }

    override public void OutputName()
    {
        Console.Write("S_");
        base.OutputName();
    }
    public static void SalariedEmpTests()
    {
        SalariedEmp emp3 = new SalariedEmp("jane", "bristol", 100, 10000);

        emp3.OutputSalary();

        emp3.SetSalary(15000);

        emp3.OutputSalary();

        emp3.OutputName();
    }

}
