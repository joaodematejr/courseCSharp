using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda";
                    break;
                case 3:
                    day = "Terça";
                    break;
                case 4:
                    day = "Quarta";
                    break;
                case 5:
                    day = "Quinta";
                    break;
                case 6:
                    day = "Sexta";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Dia Invalido";
                    break;
            }
            Console.WriteLine(day);
        }
    }
}
