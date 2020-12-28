using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "João", "Bob", "Patric", "Ana" };

            foreach (var item in vect)
            {
                Console.WriteLine(item);
            }
        }
    }
}
