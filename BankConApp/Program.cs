using System;

using BankLibrary;

namespace BankConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Welcome to Bank App: " + DateTime.Now);

      //count acc = new Account(101, "Tintin", 9000.87m);
      SavingsAccount acc = new SavingsAccount(101, "Tintin", 9000.87m);

      Console.WriteLine($"AccountNumber: {acc.AccountNumber}, HoldersName: {acc.HoldersName}, Balance: {acc.Balance}");
      acc.Deposit(100);
      Console.WriteLine($"New Balance: {acc.Balance}, After 100 Deposit");
      acc.Withdraw(100);
      //acc.Balance = 100000;
      Console.WriteLine($"New Balance: {acc.Balance}, After 100 Withdrawn");

    }
  }
}

