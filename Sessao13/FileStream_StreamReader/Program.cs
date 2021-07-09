using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";

            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path);
                string line = sr.ReadLine();
                Console.WriteLine("Primeira Linha: " + line);

                Console.WriteLine();
                Console.WriteLine("TODAS:");
                while (!sr.EndOfStream)
                {
                    string ln = sr.ReadLine();
                    Console.WriteLine(ln);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) sr.Close();
            }


        }
    }
}
