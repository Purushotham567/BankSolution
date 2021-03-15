using System;

using BankLibrary;

namespace BankConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Welcome to Bank App: " + DateTime.Now);

      Account acc = new Account(101, "Tintin", 9000.87m, "SA");

      Console.WriteLine($"AccountNumber: {acc.AccountNumber}, HoldersName: {acc.HoldersName}, Balance: {acc.Balance}, AccountType: {acc.AccountType}");
      acc.Deposit(100);
      Console.WriteLine($"New Balance: {acc.Balance}, After 100 Deposit");
      acc.Withdraw(8603); 
      Console.WriteLine($"New Balance: {acc.Balance}, After 100 Withdrawn");

    }
  }
}

