using System;

namespace Eventdemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Clock c = new Clock();
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(c);

            Inventory Inv = new Inventory();
            Inv.Subscribe(c);

            c.Run();
        }
    }
}
