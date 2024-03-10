using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class BankAccount: IBank
    {
        private string _accountNumner;
        private string _accountOwner;
        private double _balance;

        public string AccountNumber
        {
            get
            {
                return _accountNumner;
            }
            set
            {
                if (_checkAccountNumber(value))
                {
                    _accountNumner = value;
                }
                else
                {
                    throw new Exception("Invalid Account Number!");
                }
            }
        }
        public string AccountOwner
        {
            get
            {
                return _accountOwner;
            }
            set
            {
                _accountOwner = value;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid balance!");
                }

                _balance = value;
            }
        }

        public BankAccount(string accountNumber, string accountOwner, double balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountOwner = accountOwner;
            this.Balance = balance;
        }

        public bool Deposit(double amount)
        {

            this.Balance += amount;
            return true;

        }
        public bool withdraw(double amount)
        {
            try
            {
                this.Balance -= amount;
                return true;
            }
            catch
            {
                throw new Exception("you don't have enough money!");
            }

        }
        public string DisplayDetails()
        {
            string details = "Mr " + this.AccountOwner + " with account number: " + this.AccountNumber + " have " + this.Balance + " money";
            return details;
        }

        private bool _checkAccountNumber(string accountNumber)
        {
            if (accountNumber.Length != 16) // because all persian account number has 16 digits
            {
                return false;
            }
            foreach (char c in accountNumber)
            {
                try
                {
                    Convert.ToInt16(c);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
    }
}
