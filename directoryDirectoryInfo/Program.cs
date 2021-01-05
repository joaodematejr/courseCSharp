using System;
using System.IO;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/Users/joaodematejr/Documents/github/courseCSharp/temp/";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                //OR
                //var folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (var s in folders)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (var f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(sourcePath + @"/newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
