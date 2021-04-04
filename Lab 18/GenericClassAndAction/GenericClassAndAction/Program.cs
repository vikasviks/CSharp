﻿using System;

namespace GenericClassAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal<int> intcal = new Cal<int>
            {
                echo = 3
            };
            intcal.Display(new Action(() => Console.WriteLine(intcal.echo * intcal.echo)));

            Cal<Products> cal = new Cal<Products>
            {
                echo = new Products(3, 500, "Title", "Owner")
            };
            cal.Display(new Action(() => Console.WriteLine($"Price {cal.echo.Price}")));
        }
    }
}
