using System;

namespace Else
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                System.Console.WriteLine("Par!");
            } 
            else 
            {
               System.Console.WriteLine("Impar!"); 
            }
        }
    }
}
