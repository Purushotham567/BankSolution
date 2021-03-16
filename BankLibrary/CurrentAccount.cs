using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  public class CurrentAccount : Account
  {
    private readonly decimal _odLimit;
    public CurrentAccount(int accountNumber, string holdersName, decimal balance, decimal odLimit) : base(accountNumber, holdersName, balance)
    {
      _odLimit = odLimit;
    }

    public CurrentAccount(int accountNumber, string holdersName, decimal balance) : this(accountNumber, holdersName, balance, 0) { }

    public override void Withdraw(decimal amount)
    {
      if (amount < 1)
      {
        throw new NegativeException($"withdraw amount cannot be 0 or less");
      }
      if (((Balance + _odLimit) - amount) < 0)
      {
       throw new InsufficientFundsException(AccountNumber, Balance, amount, $"Insufficient Funds in CurrentAccount, Can withdraw upto: {Balance + _odLimit}");
      }
      Balance -= amount;
      //D:Step III
      if (WOnBalanceChanged != null) { WOnBalanceChanged(AccountNumber, "Withdraw", amount, Balance); }

    }
  }
}
