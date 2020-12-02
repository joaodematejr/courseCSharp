using System;
using System.Globalization;

namespace Curso
{
    class Demo
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.357584;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} Reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} Reais");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " Reais ");
        }
    }
}
