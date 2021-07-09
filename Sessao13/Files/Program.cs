using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
