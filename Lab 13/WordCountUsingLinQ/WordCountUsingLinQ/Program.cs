using System;
using System.Linq;
using System.Collections;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find word in paragraph");
            string paragraph = " It is important to understand, however," +
                " that the aim in teaching this was not to impart a hard-and-fast rule of grammar, " +
                "drawn from an authoritative-but-dusty book. The true aim of this strategy was to teach you " +
                "that your ideas must be well supported to be persuasive and effective.";

            string word = "to";

            var arr = paragraph.Split(" ");

            var count = (from i in arr where i == word select i).ToList();
            Console.WriteLine("Lambda expression : ");
            Console.WriteLine(count.Count());

            var count2 = arr.Where(x => x == word);
            foreach (string element in count2)
            {
                Console.WriteLine($"Element : {element}");

            }
            Console.WriteLine("Linq : ");
            Console.WriteLine(count2.Count());

        }
    }
}