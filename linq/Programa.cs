using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //SPECIFY THE DATA SOURCE
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //DEFINE THE QUERY EXPRESSION
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);


            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
