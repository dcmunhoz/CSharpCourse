using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {


            /* EXERCICIO 1
            double[,] mat = new double[2,3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
            */

            /* Exercicio 1
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int[] diagonal = new int[n];
            int negatives = 0;

            for (int i = 0; i < n; i++)
            {

                string line = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(line.Split(" ")[j]);
                }

            }

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (x == y) diagonal[x] = mat[x, y];
                    if (mat[x, y] < 0) negatives++;
                }
            }

            Console.WriteLine("Main diagonal: ");
            foreach (int num in diagonal)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Negative numbers = {negatives}");
            */

            // Exercicio 2
            string[] line = Console.ReadLine().Split(' ');
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);

            int[,] mat = new int[x, y];

            for (int i = 0; i < x; i++)
            {

                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse(row[j]);
                }

            }

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mat[i, j] == number)
                    {
                        Console.WriteLine($"Position: {i},{j}");
                        if (!(j - 1 < 0)) Console.WriteLine($"Left: {mat[i,j-1]}");
                        if (!(i - 1 < 0)) Console.WriteLine($"Top: {mat[i-1,j]}");
                        if (!(j + 1 >= y)) Console.WriteLine($"Right: {mat[i, j+1]}");
                        if (!(i + 1 >= x)) Console.WriteLine($"Bottom: {mat[i+1,j]}"); 

                    }
                }
            }
        }
    }
}
