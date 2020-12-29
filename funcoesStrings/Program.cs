using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG         ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'X');
            string s7 = original.Replace("abc", "yx");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("To Upper: -" + s1 + "-");
            Console.WriteLine("To Lower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOF('bc') -" + n1 + "-");
            Console.WriteLine("LastIndex('bc') -" + n2 + "-");
            Console.WriteLine("Substring('3') -" + s4 + "-");
            Console.WriteLine("Substring('3, 5') -" + s5 + "-");
            Console.WriteLine("Replace('a, X') -" + s6 + "-");
            Console.WriteLine("Replace('abc, yx') -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace -" + b2 + "-");
        }
    }
}
