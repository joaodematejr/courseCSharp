using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 10;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}