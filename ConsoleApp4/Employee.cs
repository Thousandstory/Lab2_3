using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee
    {

        private string name;
        private string surname;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void CalculateSalaryAndTax(string position, int experience)
        {
            double baseSalary = 0.0;
            double tax = 0.0;

            switch (position.ToLower())
            {
                case "manager":
                    baseSalary = 3000.0;
                    break;
                case "developer":
                    baseSalary = 4000.0;
                    break;
                case "designer":
                    baseSalary = 3500.0;
                    break;
            }

            if (experience >= 3)
            {
                baseSalary += 500.0;
            }

            tax = baseSalary * 0.1;

            Console.WriteLine("Інформація про співробітника:");
            Console.WriteLine($"Прізвище: {name}");
            Console.WriteLine($"Ім'я: {surname}");
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Оклад: {baseSalary:C2}");
            Console.WriteLine($"Податковий збір: {tax:C2}");
        }
    }
}
