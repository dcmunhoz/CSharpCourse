using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Daniel";
            cookies["email"] = "daniel@email.com";
            cookies["fone"] = "998775646";
            cookies["fone"] = "125479852";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["user"]);


            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("Key not found");
            }

            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string, string> cookie in cookies)
            {
                Console.WriteLine(cookie.Key + ":" + cookie.Value) ;
            }





        }
    }
}
