using System;

namespace EntradaDado
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            string[] vet = Console.ReadLine().Split(" ");
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];


        }
    }
}
