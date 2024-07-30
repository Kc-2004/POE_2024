using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public interface IBankAccount
    {
        void MakeDeposit(decimal amount);

        void MakeWithDraw(decimal amount);

        decimal GetBalance();
    }
}
