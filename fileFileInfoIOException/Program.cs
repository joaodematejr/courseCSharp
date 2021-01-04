using System;
using System.IO;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/Users/joaodematejr/Desktop/Oi.txt";
            string targetPath = @"/Users/joaodematejr/Desktop/Oi2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
