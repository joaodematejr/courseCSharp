using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5F;
            double n6 = 4.5;
            string nome = "Maria";
            object obj = "João";
            object obj1 = "Junior";



            Console.WriteLine(obj);
            Console.WriteLine(obj1);
            Console.WriteLine(nome);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("======\\\\\\======");


            int n11 = int.MaxValue;
            int n22 = int.MinValue;
            sbyte n33 = sbyte.MaxValue;
            decimal n44 = decimal.MaxValue;

            Console.WriteLine(n11);
            Console.WriteLine(n22);
            Console.WriteLine(n33);
            Console.WriteLine(n44);
        }
    }
}
