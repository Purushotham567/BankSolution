using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  public class SavingsAccount : Account
  {
    private readonly decimal _minBalance;

    public SavingsAccount(int accountNumber, string holdersName, decimal balance) : base(accountNumber, holdersName, balance)
    {
      _minBalance = 500;
      if (balance < _minBalance)
      {
        throw new ArgumentException($"Savings Account should have a minimum opening balance of {_minBalance}");
      }
    }

    public override void Withdraw(decimal amount)
    {
      if (amount < 1)
      {
        throw new ArgumentNullException($"withdraw amount cannot be 0 or less");
      }
      if ((Balance - amount) < _minBalance)
      {
        throw new ArgumentNullException($"Insufficient funds in SavingsAccount, can withdraw upto: {Balance - _minBalance}");
      }
      Balance -= amount;
    }
  }
}
