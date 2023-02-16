using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single customers bank account
    /// </summary>
    /// <param name="accOwner">Account owners full name</param>
    public class Account
    {
        public Account(string accOwner)
        {
            Owner = accOwner;
            Balance = 0;
        }
        /// <summary>
        /// Account owners full name
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// Amount of money in account
        /// </summary>
        public double Balance { get; private set; }
        /// <summary>
        /// Adds given amount to account
        /// </summary>
        /// <param name="amount">amount to deposit</param>
        public double Deposit(double amount) 
        {
            return Balance += amount;
        }
        /// <summary>
        /// Removes given amount from account
        /// </summary>
        /// <param name="amount">amount to take from balance</param>
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
