using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("______");

            bool c5 = a < 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

        }
    }
}
