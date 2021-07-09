using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Exercicio1.Entities;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path >: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    while (!reader.EndOfStream)
                    {

                        string[] line = reader.ReadLine().Split(",");
                        string name = line[0];
                        double price = Double.Parse(line[1], CultureInfo.InvariantCulture);

                        list.Add(new Product(name, price));

                    }
                }

                var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average price : " + avg.ToString("F2", CultureInfo.InvariantCulture));

                var names = from p in list
                            where p.Price < avg
                            orderby p.Name descending
                            select p.Name;

                foreach (string s in names)
                {
                    Console.WriteLine(s);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine( e.Message);
            }
        }
    }
}
