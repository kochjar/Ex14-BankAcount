using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        // Backing Fields & attributter
        private string _name;
        private double _balance;
        private bool _locked;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Balance
        {
            get { return _balance; }
        }

        public BankAccount(double balance) {
            this._name = "";
            this._balance = balance;
            this._locked = false;
        }
        public BankAccount(string name, double balance)
        {
            this._name = name;
            this._balance = balance;
            this._locked = false;
        }
        public BankAccount(string name, double balance, bool locked)
        {
            this._name = name;
            this._balance = balance;
            this._locked = locked;
        }

        public void Deposit(double amount)
        {
            if (_locked)
            {
                Console.WriteLine("Can't deposit to a locked account.");
                return;
            } 

            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (_locked)
            {
                Console.WriteLine("Can't withdraw money from a locked account.");
                return;
            } 

            if (amount > _balance)
            {
                Console.WriteLine($"The requested withdrawal amount is greater than the available balance of ${_balance}");
                return;
            }
            _balance -= amount;
        }

        public void ChangeLockState()
        {
            if (_locked) {_locked = false;}
            else {_locked = true;}
        }

        public override string ToString()
        {
            return $"Name: {Name}, Balance: {Balance}";
        }

    }
}
