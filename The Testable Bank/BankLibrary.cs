using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Testable_Bank
{
    public class Bank
    {
        private readonly string _customer;
        private double _balance;

        public Bank() { }

        public Bank(string customer, double balance)
        {
            if (balance > 10000 || balance <= 0)
                throw new ArgumentOutOfRangeException("amount");
            _customer = customer;
            _balance = balance;
        }

        public string Customer
        {
            get { return _customer; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public double Withdraw(double amount)
        {
            if (amount > 500)
                amount = 500;

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance -= amount;
            return _balance;
        }

        public double Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            _balance += amount;
            return _balance;
        }
    }
}
