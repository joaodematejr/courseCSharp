﻿using System;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            int a = (int)printService.First();
            int b = a + 2;
            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
