using System;
using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("João");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Ademir");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2);

            Console.WriteLine("________________");
            List<string> list2 = list.FindAll(x => x.Length == 3);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("________________");
            list.Remove("Bob");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("________________");
            list.RemoveAll(x => x[0] == 'J');
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("________________");
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
