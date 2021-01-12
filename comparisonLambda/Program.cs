using System;
using Curso.Entities;
using System.Collections.Generic;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Notebook", 900.0));
            list.Add(new Product("Tablet", 900.0));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }

    }
}
