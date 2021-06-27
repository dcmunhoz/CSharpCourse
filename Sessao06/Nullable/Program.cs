using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Double x = null;
            //Nullable<Double> x = null;
            double? x = null;
            double? y = 10.0;

            DateTime? d = null;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            // Null Coalescing

            Double? a = null;

            Double b = a ?? 0.1;
            //Double b = (a.HasValue) ? a.Value : 0.0;

            /*
            Double b;
            if (a.HasValue)
            {
                b = a.Value;
            } else
            {
                b = 0.0;
            }
            */

            Console.WriteLine(b);


        }
    }
}
