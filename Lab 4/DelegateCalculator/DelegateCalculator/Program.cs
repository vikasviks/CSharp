using System;

namespace DelegateCalculator
{
    class Program
    {   
        public delegate void CalDelegate(int a,int b);
        static void Main(string[] args)
        {
            CalDelegate d = new CalDelegate(Add);
            d(20, 10);

            d = Sub;
            d(20, 10);
            
            d = Mul;
            d(20, 2);
            
            d = Div;
            d(20, 10);
        }
        static void Add(int a, int b) {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        static void Div(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}
