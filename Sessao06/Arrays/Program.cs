using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int[] vet = new int[10];

            vet[0] = 1;
            vet[1] = 2;
            vet[2] = 3;
            vet[3] = 1;
            vet[4] = 1;

            */

            /* EXEMPLO 1
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += vet[i];
            }

            double avg = sum / n;

            Console.WriteLine(avg);
            */

            /* EXEMPLO 2
            int n = int.Parse(Console.ReadLine());

            Produto[] prod = new Produto[n];

            for (int i = 0; i < n; i++)
            {

                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                prod[i] = new Produto()
                {
                    Nome = nome,
                    Preco = preco
                };
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += prod[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine(avg);
            */

            // EXERCICIO

            Console.Write("How many rooms will be ranted? ");
            int n = int.Parse(Console.ReadLine());

            Room[] rooms = new Room[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent#" + i.ToString());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                rooms[room] = new Room() { Nome = name, Email = email, Number = room};

            }

            for (int i = 0; i < 10; i ++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i].ToString());
                }
            }


        }
    }
}
