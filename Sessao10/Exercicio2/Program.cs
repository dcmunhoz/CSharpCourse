using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio2.Entities;
using Exercicio2.Entities.Enums;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes >: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle? (r/c) >: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red)");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width >: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height >: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Rectangle rect = new Rectangle(color,width, height);
                    list.Add(rect);

                }else
                {
                    Console.Write("Radius >: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));

                }

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
