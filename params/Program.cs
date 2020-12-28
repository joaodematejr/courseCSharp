using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 9, 9, 9);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
