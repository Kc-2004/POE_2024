using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public class BankAccount : IBankAccount
    {
        public string AccountOwner { get; set;  }
        
        public string AccountNumber { get; private set; }

        public decimal Balance { get; private set; }
        public BankAccount(string accountOwner,
            string accountNumber,
            decimal initialBalance)
        {
            AccountOwner = accountOwner;
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public BankAccount()
        {
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void MakeDeposit(decimal amount)
        {
          Balance += amount;
        }

        public void MakeWithDraw(decimal amount)
        {
            if ((Balance - amount)<0) 
              throw new InvalidOperationException("No hay fondos suficientes");

            if (amount < 0)
                throw new InvalidOperationException("La cantidad debe ser mayor que 0");
            
            Balance -= amount;
            
        }
    }
}
