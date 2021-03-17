using System;

namespace BankLibrary
{
  //D:Step I, Declare the Delegate
  [Serializable]
  public delegate void OnBalanceChanged(int accountNumber, string transactionType, decimal transactionAmount, decimal newBalance);

  [Serializable]
  public abstract class Account
  {
    private int _accountNumber;
    private string _holdersName;
    private decimal _balance;
    //D:Step II Create ref of the Delegate
    public OnBalanceChanged WOnBalanceChanged;
    //D:Step II Create ref of the Delegate
    public event OnBalanceChanged DOnBalanceChanged;
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
        throw new NegativeException($"deposit amount cannot be 0 or less");
      }
      _balance += amount;
      //D:Step III
      if (DOnBalanceChanged != null) { DOnBalanceChanged(_accountNumber, "Deposit", amount, _balance); }

    }

    public abstract void Withdraw(decimal amount);

    public override string ToString()
    {
      return $"AccountNumber: {_accountNumber}, HoldersName: {_holdersName}, Balance: {_balance}";
    }
  }
}
