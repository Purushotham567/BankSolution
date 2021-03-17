using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  [Serializable]
  public class SavingsAccount : Account
  {
    private readonly decimal _minBalance;

    public SavingsAccount(int accountNumber, string holdersName, decimal balance) : base(accountNumber, holdersName, balance)
    {
      _minBalance = 500;
      if (balance < _minBalance)
      {
        throw new OpeningBalanceException($"Savings Account should have a minimum opening balance of {_minBalance}");
      }
    }

    public override void Withdraw(decimal amount)
    {
      if (amount < 1)
      {
        throw new NegativeException($"withdraw amount cannot be 0 or less");
      }
      if ((Balance - amount) < _minBalance)
      {
        throw new InsufficientFundsException(AccountNumber, Balance, amount, $"Insufficient funds in SavingsAccount, can withdraw upto: {Balance - _minBalance}");
      }
      Balance -= amount;
      //D:Step III
      if (WOnBalanceChanged != null) { WOnBalanceChanged(AccountNumber, "Withdraw", amount, Balance); }
    }
  }
}
