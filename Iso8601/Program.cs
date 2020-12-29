using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:50Z");

            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 Kind " + d1.Kind);
            Console.WriteLine("D1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("D1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2 Kind " + d2.Kind);
            Console.WriteLine("D2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("D2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}
