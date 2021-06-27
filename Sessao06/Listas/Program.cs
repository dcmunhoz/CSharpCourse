using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exemplo 1
            List<string> lista = new List<string>();

            List<string> lista2 = new List<string> { "Daniel", "eduardo" };
            */

            /* EXEMPLO 2
            List<String> list = new List<String>();

            list.Add("Daniel");
            list.Add("Costa");
            list.Add("Munhoz");

            list.Insert(1, "Daniboy");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            } 


            Console.WriteLine("Quantidade: " + list.Count);


            string s1 = list.Find((x) => x == "Costa" );
            Console.WriteLine(s1);


            List<String> s2 = list.FindAll(x => x[0] == 'D');
            foreach (string achados in s2)
            {
                Console.WriteLine(achados);
            }

            */

            // Exercicio

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Employee emp = new Employee();
                Console.WriteLine($"Employee #{i}");
                Console.Write("ID: ");
                emp.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                emp.Name = Console.ReadLine();
                Console.Write("Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                employees.Add(emp);
            
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int n2 = int.Parse(Console.ReadLine());

            int index = employees.FindIndex(x => x.Id == n2);

            if (index == -1)
            {
                Console.WriteLine("this id does not exist !");

            }else
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());

                Employee emp2 = employees.Find(x => x.Id == n2);

                emp2.increnseSalary(percent);

            }

            Console.WriteLine(" ");
            Console.WriteLine("Updated List: ");

            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj.ToString());
            }





        }
    }
}
