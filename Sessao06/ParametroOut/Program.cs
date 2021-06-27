using System;

namespace ParametroOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int result;

            Calculator.Triple(a, out result);
            Console.WriteLine(result);
        }
    }
}
