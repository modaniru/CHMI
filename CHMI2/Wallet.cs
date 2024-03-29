using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CHMI2
{
    public class Wallet
    {
        public int Balance = 0;

        public List<Transaction> transactions = new List<Transaction>();

        public Wallet()
        {
        }


       

        public void SetBalance(int balance)
        {
            Balance = balance;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public int GetCount()
        {
            return transactions.Count;
        }

        public List<Transaction> GetList()
        {
            return transactions;
        }

        //public void AddTransaction(string Type, string Name, string Category, string Date, int Value)
        //{
        //    Transaction trans = new(Type, Name, Category, Date, Value);
        //    transactions.Add(trans);
        //}

        public void AddTransaction(Transaction trans)
        {
            //Transaction trans = new(Type, Name, Category, Date, Value);
            transactions.Add(trans);
        }
        //~Wallet() { }
    }


}
