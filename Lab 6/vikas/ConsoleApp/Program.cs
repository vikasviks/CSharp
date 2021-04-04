using infrastructure;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory products = new Inventory();
            Console.WriteLine(products.ToString());
            products.displayProduct(new core.Product {
            Title = "Scale",
            Color = "White",
            Price = 10
            });

        }
    }
}
