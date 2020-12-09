using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // =  a = 10; a Recebe 10
            // += a += 2; a Recebe a + 2;
            // -= a -= 2; a Recebe a - 2;
            // /= a /= 2; a Recebe a / 2;
            // %= a %= 3; a Recebe a % 3;

            int a = 10;
            a++;
            //int b = a++;
            Console.WriteLine(a);//11
            a--;
            Console.WriteLine(a);//10
        }
    }
}
