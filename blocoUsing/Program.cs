using System;
using System.IO;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/joaodematejr/Documents/github/courseCSharp/temp/file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
