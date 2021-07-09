using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datasource
            int[] numbers = new int[] { 1,2,3,4,5,6,7,8,9,10 };

            // Query
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execution
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }


        }
    }
}
