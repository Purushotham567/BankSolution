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
    }

    public override void Withdraw(decimal amount)
    {
      if ((Balance - amount) < _minBalance)
      {
        Console.WriteLine($"Insufficient funds in SavingsAccount, can withdraw upto: {Balance - _minBalance}");
        return;
      }
      Balance -= amount;
    }
  }
}
