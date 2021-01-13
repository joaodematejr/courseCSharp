using System;
using Curso.Services;


namespace Curso
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op.Invoke(a, b);

            Console.WriteLine(result);
        }
    }
}
