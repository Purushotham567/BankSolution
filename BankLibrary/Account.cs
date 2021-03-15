using System;

namespace BankLibrary
{
  public class Account
  {
    int _accountNumber;
    string _holdersName;
    decimal _balance;

    public Account(int accountNumber, string holdersName, decimal balance)
    {
      _accountNumber = accountNumber;
      _holdersName = holdersName;
      _balance = balance;      
    }

    public int AccountNumber
    {
      get { return _accountNumber; }
    }

    public string HoldersName
    {
      get { return _holdersName; }
      set { _holdersName = value;}
    }

    public decimal Balance
    {
      get { return _balance; }
      set { _balance = value; }
    }

    public void Deposit(decimal amount)
    {
      _balance += amount;    
    }

    public void Withdraw(decimal amount)
    {
    }
  }
}
