using System;
using System.Collections.Generic;
using System.Globalization;
using PolimorfismoAula130.Entities;


namespace PolimorfismoAula130
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} Data: ");
                Console.Write("Outsoursed (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    list.Add(new OutsoursedEmployee(name, hours, valuePerHour, additionalCharge));

                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            Console.WriteLine();

            // Percorrendo a lista:
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
