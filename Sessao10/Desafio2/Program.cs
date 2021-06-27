using System;
using System.Collections.Generic;
using System.Globalization;
using Desafio2.Entities;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers >: ");
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();
            double totalTaxes = 0.0;

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or Company (i/c)? >: ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name >: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income >: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {

                    Console.Write("Health Expendiures >: ");
                    double expanditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, expanditures));

                } else
                {
                    Console.Write("Number of Employees >: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (Person person in list)
            {
                totalTaxes += person.Taxes();
                Console.WriteLine($"{person.Name}: $ {person.Taxes().ToString("F2", CultureInfo.InvariantCulture)}");

            }

            Console.WriteLine( );
            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
