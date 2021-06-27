using System;
using System.Globalization;
using Desafio.Entities;
using Desafio.Entities.Enums;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-- Enter client data --");
            
            Console.Write("Name >: ");
            string name = Console.ReadLine();
            Console.Write("Email >: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY) >: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            Console.WriteLine("-- Enter Order Data -- ");

            Console.Write("Status >: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? >: ");
            int quantity = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, client);

            Console.WriteLine();
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"-- Enter #{i} item data -- ");
                Console.Write("Product Name >: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price >: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity >: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantityProduct, price, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("-- ORDER SUMARY --");
            Console.WriteLine(order);
        }
    }
}
