using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuchhaltungConsolenApp
{
    [Serializable]
    class Transaction
    {
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }


        public Transaction(string name, decimal amount, DateTime date)
        {
            Name = name;
            Amount = amount;
            Date = date;
        }

        public override string ToString()
        {
            return "Name: " + Name + " | Datum: " + Date.ToShortDateString() + " | Betrag: " + Amount + " EURO";
        }
    }
}
