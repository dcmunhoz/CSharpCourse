﻿using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio1.Entities;


namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();


            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} Data");
                Console.Write("Outsourced? (y/n) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }



            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - R${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }


        }
    }
}
