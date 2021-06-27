using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Daniel", "Eduardo", "Bianchi" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
