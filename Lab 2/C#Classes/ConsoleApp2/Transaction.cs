﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Transaction
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }

    }
}
