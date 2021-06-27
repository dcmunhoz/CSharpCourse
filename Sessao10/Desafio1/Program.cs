using System;
using System.Collections.Generic;
using Desafio1.Entities;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products >: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} Data -- ");
                Console.Write("Common, used or imported ? (c/u/i) >: ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name >: ");
                string name = Console.ReadLine();

                Console.Write("Price >: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Customs Fee >: ");
                    double customsFree = double.Parse(Console.ReadLine());

                    ImportedProduct imp = new ImportedProduct(name, price, customsFree);
                    products.Add(imp);

                } else if (ch == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY) >: ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());

                    UsedProduct used = new UsedProduct(name, price, manufacture);
                    products.Add(used);
                } else
                {
                    Product common = new Product(name, price);
                    products.Add(common);
                }


            }

            Console.WriteLine();
            Console.WriteLine("PROCE TAGS --");
            foreach (Product prod in products)
            {

                Console.WriteLine(prod.PriceTag());

            }





        }
    }
}
