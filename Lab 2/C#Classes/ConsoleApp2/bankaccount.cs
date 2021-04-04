using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class bankaccount
    {
        private static int initialaccountnumber = 123456789;
        List<Transaction> alltransactions = new List<Transaction>();
        public string Number { get; set; }
        public string owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var items in alltransactions)
                {
                    balance += items.Amount;
                }
                return balance;
            }

        }
        public bankaccount(string name, decimal initialbalance)
        {
            this.Number = initialaccountnumber.ToString();
            initialaccountnumber++;
            this.owner = name;
            MakeDeposit(initialbalance, DateTime.Now, "inital balance");
        }
        public bankaccount()
        {

        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount cannot be less than 0");
            }
            var deposit = new Transaction(amount, date, note);
            alltransactions.Add(deposit);


        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount To Be Withdrawl Must Be Positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("not sufficiennts funds for withdrawal");
            } 
            var withdrwal = new Transaction(-amount, date, note);
            alltransactions.Add(withdrwal);
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\t\tBalance\tNote");
            foreach (var items in alltransactions)
            {
                balance += items.Amount;
                report.AppendLine($" {items.Date.ToShortDateString()}\t{items.Amount}\t{balance}\t{items.Notes}");

            }
            return report.ToString();
        }

    }

}
