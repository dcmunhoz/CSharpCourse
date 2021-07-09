using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            HashSet<string> hs = new HashSet<string>();

            hs.Add("TV");
            hs.Add("Notebook");
            hs.Add("Tablet");


            Console.WriteLine(hs.Contains("Notebook"));

            foreach (string s in hs)
            {
                Console.WriteLine(s);
            }
            */

            SortedSet<int> a = new SortedSet<int>() { 0,2,4,5,2,6,8,4,2 };
            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10};


            // uniot
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(c);
            PrintCollection(d);
            PrintCollection(e);

        }
        
        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + ", ");
            }
            Console.WriteLine();
        }


    }
}
