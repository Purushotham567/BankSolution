using System;

using BankLibrary;

namespace BankConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Account acc;


      acc = new SavingsAccount(101, "Tintin", 9000.87m);
      //acc = new CurrentAccount(201, "Mandrake", 7000.00m, 2000);
      //acc = new CurrentAccount(202, "Snowy", 7000.00m);
      //acc = new FixedDepositAccount(301, "Thomson", 2000.00m);

      //Console.WriteLine(acc);

      Printer.Print(message: acc.ToString(), header: "Account Details");

      acc.Deposit(100);
      Console.WriteLine($"New Balance: {acc.Balance}, After 100 Deposit");
      acc.Withdraw(100);
      Console.WriteLine($"New Balance: {acc.Balance}, After 100 Withdrawn");
      //Console.ReadKey(true);
      //acc.Withdraw(7000.90m);
      //Console.WriteLine($"New Balance: {acc.Balance}, After 7000 Withdrawn");
      Printer.Print(message: acc[0].ToString(), header: "Account Number");
      Console.WriteLine(acc[1]);
      Console.WriteLine(acc[2]);
      Console.WriteLine(acc[3]);
    }
  }
}

