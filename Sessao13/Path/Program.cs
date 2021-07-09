using System;
using System.IO;

namespace Path_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("DirectorySeparator: " + Path.DirectorySeparatorChar) ;
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("TempPath: " + Path.GetTempPath());
        }
    }
}
