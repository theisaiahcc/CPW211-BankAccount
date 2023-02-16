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
        private string owner;

        public Account(string accOwner)
        {
            Owner = accOwner;
            Balance = 0;
        }
        /// <summary>
        /// Account owners full name
        /// </summary>
        public string Owner 
        {
            get { return owner; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{Owner} cannot be null.");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException($"{Owner} cannot be empty.");
                }
                owner = value;
            }  
        }
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
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount must be more than 0");
            }
            return Balance += amount;
        }
        /// <summary>
        /// Removes given amount from account
        /// </summary>
        /// <param name="amount">amount to take from balance</param>
        public double Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount must be more than 0");
            }
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Amount can not be more than balance");
            }
            return Balance -= amount;
        }
    }
}
