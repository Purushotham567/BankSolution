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
      if (((Balance + _odLimit) - amount) < 0)
      {
        Console.WriteLine($"Insufficient Funds in CurrentAccount, Can withdraw upto: {Balance + _odLimit}");
        return;
      }
      Balance -= amount;
    }
  }
}
