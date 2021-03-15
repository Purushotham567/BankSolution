using System;

using BankLibrary;

namespace BankConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Welcome to Bank App: " + DateTime.Now);

      Account account = new Account();

      Console.Write("Enter a AccountNumber: ");
      int accountNumber = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter a HoldersName: ");
      string holdersName = Console.ReadLine();

      Console.Write("Enter a AccountType: ");
      string accountType = Console.ReadLine();

      Console.Write("Enter a Balance: ");
      decimal balance = Convert.ToDecimal(Console.ReadLine());

      account.AcceptDetails(accountNumber, holdersName, balance, accountType);
      account.DisplayDetails();
    }
  }
}

