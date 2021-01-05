using System;
using System.IO;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/Users/joaodematejr/Documents/github/courseCSharp/temp/file1.txt";
            string targetPath = @"/Users/joaodematejr/Documents/github/courseCSharp/temp/file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
