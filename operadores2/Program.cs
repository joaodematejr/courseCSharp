using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 5 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            int n4 = (double)10 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            double a = 1.0, b = 3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;
            //double delta = Math.pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / 2.0 * a;
        }
    }
}
