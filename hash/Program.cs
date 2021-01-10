using System;
using System.Collections.Generic;
using System.Globalization;
using Curso.Entities;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1900.0));

            HashSet<Point> b = new HashSet<Point>();

            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1900.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));

        }
    }
}
