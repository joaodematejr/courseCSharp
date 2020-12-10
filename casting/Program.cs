using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //4byte
            float x = 4.5f;
            //8byte
            double y = x;
            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.whiteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.whiteLine(d);

            int e = 5;
            int f = 2;

            double resultado = (double)a / b;

            Console.whiteLine(resultado);
        }
    }
}
