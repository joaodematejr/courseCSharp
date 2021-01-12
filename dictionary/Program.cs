﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "997122334";
            cookies["phone"] = "937337333";
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);
            cookies.Remove("email");
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size " + cookies.Count);

            Console.WriteLine("All Cookies");
            //or var item
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
