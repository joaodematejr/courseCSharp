﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //List<string> result = list.Select(NameUpper).ToList();

            //Func<Product, string> func = NameUpper;

            //Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

       // static string NameUpper(Product p)
       // {
       //     return p.Name.ToUpper();
       // }
    }
}
