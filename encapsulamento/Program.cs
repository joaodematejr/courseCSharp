using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.000, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}