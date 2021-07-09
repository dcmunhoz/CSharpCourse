using System;
using System.IO;
using System.Collections.Generic;
using Exercicio1.Entities;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path >: ");
            string path = Console.ReadLine();

            HashSet<LogRecord> list = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        list.Add(new LogRecord { Username = name, Instant = instant });

                    }
                    Console.WriteLine("Total Users: " + list.Count);
                }

            
            
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
