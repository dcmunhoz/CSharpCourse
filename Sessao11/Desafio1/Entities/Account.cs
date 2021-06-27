using System;
using System.Collections.Generic;
using System.Text;
using Desafio1.Entities.Exceptions;

namespace Desafio1.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new AccountException("Not enough limit !");
            }

            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
