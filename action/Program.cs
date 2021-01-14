using System;
using System.Collections.Generic;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = UpdatePrice;
            //or
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(UpdatePrice);

            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }


    }
}
