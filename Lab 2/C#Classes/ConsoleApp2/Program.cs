using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new bankaccount("foo", 10000);
           // acc1.MakeWithdrawal(15000, DateTime.Now, "first-w");
            Console.WriteLine(acc1.Balance);
            try
            {
                acc1.MakeWithdrawal(16000, DateTime.Now, "first w");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.WriteLine(acc1.GetAccountHistory());
            Console.WriteLine("for account 2");
            var acc2 = new bankaccount("koo", 30000);
            acc2.MakeDeposit(4999, DateTime.Now, "deposited");
            acc2.MakeWithdrawal(20000, DateTime.Now, "withdrawal");
            Console.WriteLine(acc2.GetAccountHistory());
            

        }
    }
}
