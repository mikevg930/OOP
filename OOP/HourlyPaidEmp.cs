using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class HourlyPaidEmp : Employee
    {
        private double HourlyRate;
        public HourlyPaidEmp(string name, string address, int ninumber, double hourlyrate) : base (name, address, ninumber)
        {
            HourlyRate = hourlyrate;
        }

        public void OutputHourlyRate()
        {
             Console.WriteLine(HourlyRate);
        }
        public void SetHourlyRate(double newhourlyrate)
        {
            HourlyRate = newhourlyrate;
        }

        override public void OutputName() 
        {
            Console.Write("E_");
            base.OutputName();
        }
        public static void HourlyPaidEmpTests()
        {
        HourlyPaidEmp emp2 = new HourlyPaidEmp("john", "bath", 100, 15.0);
            emp2.OutputHourlyRate();
            emp2.SetHourlyRate(16.5);
            emp2.OutputHourlyRate();
            emp2.OutputName();
        }

    }

