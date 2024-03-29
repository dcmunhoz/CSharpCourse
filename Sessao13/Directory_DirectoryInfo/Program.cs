﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\temp\myfolder";

            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }


                Directory.CreateDirectory(path + "\\newfolder");


            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred:");
                Console.WriteLine(e.Message);
            }


        }
    }
}
