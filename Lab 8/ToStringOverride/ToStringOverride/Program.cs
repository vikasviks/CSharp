using System;

namespace ToStringOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Product obj = new Product {
                Id = 1,
                Title = "Pen",
                Price = 50
            };
            Console.WriteLine(obj.ToString());
        }
    }
}
