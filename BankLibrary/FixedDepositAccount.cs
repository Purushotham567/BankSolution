using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  public class FixedDepositAccount : Account
  {
    private readonly decimal _minOpeningBalance;

    public FixedDepositAccount(int accountNumber, string holdersName, decimal balance) : base(accountNumber, holdersName, balance)
    {
      _minOpeningBalance = 3000;
      if (balance < _minOpeningBalance)
      {
        throw new ArgumentException($"Fixed Deposit should have a minimum opening balance of {_minOpeningBalance}");
      }
    }

    public override void Deposit(decimal amount)
    {
      throw new Exception("Deposit Not supported in Fixed Deposit Account");
    }
    public override void Withdraw(decimal amount)
    {
      throw new Exception("Withdraw Not supported in Fixed Deposit Account");
    }

  }
}
