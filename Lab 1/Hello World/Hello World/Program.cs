using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!");
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Hello {name} on {date}");
            Console.ReadKey(true);
        }
    }
}
