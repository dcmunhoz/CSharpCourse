using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p;
            p.x = 10;
            p.y = 5;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

        }
    }
}
