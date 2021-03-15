using System;

namespace BankLibrary
{
  public class Account
  {
    int _accountNumber;
    string _holdersName;
    decimal _balance;
    string _accountType;

    public Account(int accountNumber, string holdersName, decimal balance, string accountType)
    {
      _accountNumber = accountNumber;
      _holdersName = holdersName;
      _balance = balance;
      _accountType = accountType;
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
    public string AccountType
    {
      get { return _accountType; }
      set { _accountType = value; }
    }

    public void Deposit(decimal amount)
    {
      _balance += amount;    
    }

    public void Withdraw(decimal amount)
    {
      if (_accountType == "SA")
      {
        //SA maintaine a minBalance of 500
        if ((_balance - amount) < 500)
        {
          Console.WriteLine("Insufficient Funds in SA Account");
          return;
        }
      }
      else if (_accountType.Equals("CA"))
      {
        //CA maintaine a minBalance of 0 later with OdLimit
        if ((_balance - amount) < 0)
        {
          Console.WriteLine("Insufficient Funds in CA Account");
          return;
        }
      }
      else if (_accountType == "FD")
      {
        //FD withdraw not supported
        Console.WriteLine("Withdraw not supported in FD Account");
        return;
      }
      _balance -= amount;
    }


  }
}
