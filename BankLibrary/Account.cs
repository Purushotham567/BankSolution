using System;

namespace BankLibrary
{
  public class Account
  {
    int _accountNumber;
    string _holdersName;
    decimal _balance;
    string _accountType;

    public void AcceptDetails(int accountNumber, string holdersName, decimal balance, string accountType)
    {
      _accountNumber = accountNumber;
      _holdersName = holdersName;
      _balance = balance;
      _accountType = accountType;
    }

    public void DisplayDetails()
    {
      Console.WriteLine("AccountNumber: " + _accountNumber + ", HoldersName: " + _holdersName);
      Console.WriteLine("Balance: {0} and AccountType: {1}", _balance, _accountType);
    }
  }
}
