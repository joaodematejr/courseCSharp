using System;
using System.Collections.Generic;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Table");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

        }
    }
}
