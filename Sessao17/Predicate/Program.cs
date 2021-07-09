using System;
using System.Collections.Generic;
using System.Linq;
using Predicate.Entities;

namespace Predicate
{
    class Program
    {

        /* PREDICATES
        public static bool CompareProduct(Product p)
        {
            return p.Price >= 100.00;
        }
        */

        /* ACTIONS
        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
        */

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.60));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(CompareProduct);
            //list.ForEach(UpdatePrice);


            //Func<Product, string> func = NameUpper;
            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> resut = list.Select(func).ToList();



            foreach (string s in resut)
            {
                Console.WriteLine(s);
            }

        }


    }
}
