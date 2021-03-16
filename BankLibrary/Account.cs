﻿using System;

namespace BankLibrary
{
  public abstract class Account
  {
    private int _accountNumber;
    private string _holdersName;
    private decimal _balance;

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
      set { _holdersName = value; }
    }

    public decimal Balance
    {
      get { return _balance; }
      protected set { _balance = value; }
    }

    public Object this[int index]
    {
      get
      {
        if (index == 0)
        {
          return _accountNumber;
        }
        else if (index == 1)
        {
          return _holdersName;
        }
        else if (index == 2)
        {
          return _balance;
        }
        else
        {
          throw new IndexOutOfRangeException($"No data at the given index: {index}");
        }
      }
    }

    public virtual void Deposit(decimal amount)
    {
      if (amount < 1)
      {
        throw new ArgumentNullException($"deposit amount cannot be 0 or less");
      }

      _balance += amount;
    }

    public abstract void Withdraw(decimal amount);

    public override string ToString()
    {
      return $"AccountNumber: {_accountNumber}, HoldersName: {_holdersName}, Balance: {_balance}";
    }
  }
}
