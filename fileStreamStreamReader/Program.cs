using System;
using System.IO;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/joaodematejr/Documents/github/courseCSharp/temp/file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

        }
    }
}
