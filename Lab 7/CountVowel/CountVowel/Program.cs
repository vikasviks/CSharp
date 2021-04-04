using System;

namespace CountVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Countvowel";
            Console.WriteLine($"Vowel Count in \"{s}\": {s.CountVowels()}");
        }
    }
}
