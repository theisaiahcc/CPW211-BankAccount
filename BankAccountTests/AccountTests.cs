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
        private Account acc;

        [TestInitialize]
        public void DefaultAccount()
        {
            acc = new Account("Isaiah C");
        }

        [TestMethod()]
        [DataRow(100)]
        [DataRow(.01)]
        [DataRow(1.99)]
        [DataRow(9_999.99)]
        public void Deposit_APositiveAmount_AddToBalance(double deposit)
        {
            acc.Deposit(deposit);
            Assert.AreEqual(deposit, acc.Balance);
        }

        [TestMethod()]
        public void Deposit_APositiveAmount_ReturnUpdatedBalance()
        {
            // AAA - Arrange Act Assert
            double expected = 100;
            double balance = acc.Deposit(100);
            Assert.AreEqual(expected, balance);
        }

        [TestMethod()]
        [DataRow(-1)]
        [DataRow(0)]
        public void Deposit_ZeroOrLess_ThrowsArgumentException(double invalidDeposit)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acc.Deposit(invalidDeposit));
        }

        [TestMethod()]
        public void Withdraw_PositiveAmount_ReturnsNewBalance() 
        {
            double withdrawal = 50;
            double initialDeposit =  acc.Deposit(100);
            double balance = acc.Withdraw(withdrawal);
            Assert.AreEqual(initialDeposit - withdrawal, balance);
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(-1)]
        public void Withdraw_ZeroOrLess_ThrowsArgumentOutOfRangeException(double invalidWithdrawal)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acc.Withdraw(invalidWithdrawal));
        }

        [TestMethod]
        public void Withdraw_MoreThanBalance_ThrowsArgumentException()
        {
            acc.Deposit(100);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acc.Withdraw(101));
        }
    }
}