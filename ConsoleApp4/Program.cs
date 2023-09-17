using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Джо", "Наваро");

            employee.CalculateSalaryAndTax("developer", 5);
        }
    }
}
