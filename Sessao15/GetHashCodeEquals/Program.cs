using System;
using GetHashCodeEquals.Entities;

namespace GetHashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Maria", Email = "maria@email.com" };
            Client b = new Client() { Name = "Alex", Email = "maria@email.com" };

            Console.WriteLine(a.Equals(b));
        }
    }
}
