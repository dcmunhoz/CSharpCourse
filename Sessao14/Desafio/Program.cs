using System;
using System.Globalization;
using Desafio.Entities;
using Desafio.Services;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number >: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/mm/yyyy) >: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value >: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Number of Istallments >: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            Payment payment = new Payment(new PaypalService());
            payment.GenerateInstallments(contract, installments);

            Console.WriteLine("INSTALLMENTS: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine($"{installment.Date.ToString("dd/MM/yyyy")} - R${installment.Value.ToString("F2", CultureInfo.InvariantCulture)}");
            }


        }
    }
}
