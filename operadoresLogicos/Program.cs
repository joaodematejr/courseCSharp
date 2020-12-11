using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5; // TRUE
            System.Console.WriteLine(c1);

            bool c2 = !(2 > 3) && 4 != 5; //TRUE

            System.Console.WriteLine(c2);

            System.Console.WriteLine("_________");

            bool c3 = 10 < 5; //FALSE
            bool c4 = c1 || c2 && c3;  //TRUE

        }
    }
}
