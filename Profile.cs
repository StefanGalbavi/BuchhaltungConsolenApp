using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuchhaltungConsolenApp
{
    [Serializable]
    class Profile
    {
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public List<Transaction> Transactions { get; private set; }

        public Profile(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            Transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            Balance += transaction.Amount;
            ProfileManager.SaveProfile(this);
        }
    }
}
