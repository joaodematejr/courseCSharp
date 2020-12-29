using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t0 = TimeSpan.MaxValue;
            TimeSpan t1 = TimeSpan.MinValue;
            TimeSpan t2 = TimeSpan.Zero;

            Console.WriteLine(t0);
            Console.WriteLine(t1);
            Console.WriteLine(t2);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("----");

            TimeSpan t11 = new TimeSpan(1, 30, 10);
            TimeSpan t22 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t11.Add(t22);
            TimeSpan dif = t11.Subtract(t22);
            TimeSpan mult = t22.Multiply(2.0);
            TimeSpan div = t22.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
