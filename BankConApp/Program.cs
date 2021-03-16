using System;

using BankLibrary;

using static System.Console;

namespace BankConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Account acc;
      try
      {
        acc = new SavingsAccount(101, "Tintin", 9000.87m);
        //acc = new CurrentAccount(201, "Mandrake", 7000.00m, 2000);
        //acc = new CurrentAccount(202, "Snowy", 7000.00m);
        //acc = new FixedDepositAccount(301, "Thomson", 2000.00m);

        Printer.Print(message: acc.ToString(), header: "Account Details");

        acc.Deposit(100);
        Console.WriteLine($"New Balance: {acc.Balance}, After 100 Deposit");
        acc.Withdraw(8700);
        Console.WriteLine($"New Balance: {acc.Balance}, After 8700 Withdrawn");
        //Console.ReadKey(true);
        //acc.Withdraw(7000.90m);
        //Console.WriteLine($"New Balance: {acc.Balance}, After 7000 Withdrawn");
        Printer.Print(message: acc[0].ToString(), header: "Account Number");
        Console.WriteLine(acc[1]);
        Console.WriteLine(acc[2]);
        Console.WriteLine(acc[3]);

      }
      catch (ArgumentException ex)
      {
        WriteLine(ex);
      }
      catch (IndexOutOfRangeException ex)
      {
        WriteLine(ex);
      }
      catch (Exception ex)
      {
        WriteLine(ex);
      }
      
      #region try catch finally demo
      //try
      //{
      //  int num1 = 10, div = 0;
      //  WriteLine($"num1: {num1} / div: {div} = {num1 / div}");
      //  return;
      //}
      //catch (IndexOutOfRangeException ex)
      //{
      //  WriteLine(ex.ToString());
      //  throw;
      //}
      //catch (DivideByZeroException ex)
      //{
      //  WriteLine(ex.ToString());
      //  throw;
      //}
      //catch (ArgumentException ex)
      //{
      //  WriteLine(ex.ToString());
      //  throw;
      //}
      //catch (Exception ex)
      //{
      //  WriteLine(ex.ToString());
      //  throw;
      //}
      //finally
      //{
      //  WriteLine("From finally Bye Bye ...");
      //}
      //WriteLine("Bye Bye ...");

      #endregion

    }
  }
}

