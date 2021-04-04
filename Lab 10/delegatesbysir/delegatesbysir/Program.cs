using System;

namespace delegatesbysir
{
    class Program
    {
        public delegate void delg(string a);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
                delg d = new delg(Callbytext);
            d += Callbyphone;
            d += Callbytmeet;
            d("Done!!");

            static void Callbytext(string a)
            {
                Console.WriteLine($"Notified by text:{a}");
            }

            static void Callbyphone(string a)
            {
                Console.WriteLine($"Notified by phone :{a}");
            }

            static void Callbytmeet(string a)
            {
                Console.WriteLine($"Notified by meet :{a}");
            }
        }
    }
    
}
