using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateException
{
    public class Acount
    {
        private int Number { get; set; }
        private string Holder { get; set; }
        private double Balance { get; set; }
        private double WithdrawLimit { get; set; }

        public Acount(int number, string holder, double initialBalance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = initialBalance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            else if (amount > Balance)
                throw new DomainException("Withdraw error: Not enough balance");
            Balance -= amount;
        }

        public double ConsultBalance()
        {
            return Balance;
        }
    }
}
