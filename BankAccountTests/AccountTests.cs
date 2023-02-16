using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Deposit_APositiveAmount_AddToBalance()
        {
            Account acc = new Account("Isaiah C");
            acc.Deposit(100);
            Assert.AreEqual(100, acc.Balance);
        }

        [TestMethod()]
        public void Deposit_APositiveAmount_ReturnUpdatedBalance()
        {
            // AAA - Arrange Act Assert
            Account acc = new Account("Isaiah C");
            double expected = 100;
            double balance = acc.Deposit(100);
            Assert.AreEqual(expected, balance);
        }
    }
}