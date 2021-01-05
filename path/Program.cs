    using System;
using System.IO;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/Users/joaodematejr/Documents/github/courseCSharp/temp/file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName :" + Path.GetDirectoryName(sourcePath));
            Console.WriteLine("GetFileName: " + Path.GetFileName(sourcePath));
            Console.WriteLine("GetExtension: " + Path.GetExtension(sourcePath));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(sourcePath));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(sourcePath));
            Console.WriteLine("GetTempFileName " + Path.GetTempFileName());
        }
    }
}
