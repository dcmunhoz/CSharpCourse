using System;
using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name >: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("-- Enter Worker Data --");

            Console.Write("Name >: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior) :> ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary >: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker ? >: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-- Enter #{i} contract data --");
                Console.Write("Date (DD/MM/YYYY) >: ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour >: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (Hours) >: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(hourContract);
            
            }

            Console.WriteLine("");

            Console.Write("Enter month and year to calculate incoma (MM/YYYY) >: ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Split("/")[0]);
            int year = int.Parse(monthAndYear.Split("/")[1]);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
