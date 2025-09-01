using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    internal class BankAccount
    {
        private decimal Balance;

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Ammount must be positive.");

            Balance += amount;
        }

        public bool WithDraw(decimal amount)
        {
            if(amount > Balance)
                return false;

            Balance -= amount;
            return true;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
