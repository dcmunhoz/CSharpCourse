using System;
using Desafio1.Entities;
using Desafio1.Entities.Exceptions;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2"));
            } catch (AccountException e)
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }

        }
    }
}
