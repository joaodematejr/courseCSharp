using System;
using System.Globalization;
using curso.Entities;
using curso.Entities.Enums;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine("txt => " + txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine("os => " + os);
        }
    }
}
