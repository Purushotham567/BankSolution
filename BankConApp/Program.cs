using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        #region Deserialize code
        //FileStream fStream = new FileStream(@$"../../../Snowy-202.dat", FileMode.Open, FileAccess.Read);
        //BinaryFormatter binaryFormatter = new BinaryFormatter();
        //acc = binaryFormatter.Deserialize(fStream) as Account;
        //fStream.Close();
        //Console.WriteLine($"{acc.HoldersName}, account has been deserialized...");
        #endregion

        //acc = new SavingsAccount(101, "Tintin", 9000.87m);
        //acc = new CurrentAccount(201, "Mandrake", 7000.00m, 2000);
        acc = new CurrentAccount(202, "Snowy", 5000.00m);
        //acc = new FixedDepositAccount(301, "Thomson", 2000.00m);

        //C:Step II Initialization of the Delegate with the Method which has the same signature of the delegate
        // Note .Net Core does not support Delegate Serialization
        acc.WOnBalanceChanged += new OnBalanceChanged(SMSAlert);
        acc.WOnBalanceChanged += new OnBalanceChanged(EmailAlert);
        acc.DOnBalanceChanged += SMSAlert;
        Printer.Print(message: acc.ToString(), header: "Account Details");
        acc.Deposit(100);
        acc.Withdraw(300);

        #region Serialization Code
        //FileStream fStream = new FileStream(@$"../../../{acc.HoldersName}-{acc.AccountNumber}.dat", FileMode.Create, FileAccess.Write);
        //BinaryFormatter binaryFormatter = new BinaryFormatter();
        //binaryFormatter.Serialize(fStream, acc);
        //fStream.Close();
        //Console.WriteLine($"{acc.HoldersName}, account has been saved...");
        #endregion
      }
      catch (ArgumentException ex)
      {
        WriteLine(ex);
      }
      catch (IndexOutOfRangeException ex)
      {
        WriteLine(ex);
      }
      catch (OpeningBalanceException ex)
      {
        WriteLine(ex);
      }
      catch (NegativeException ex)
      {
        WriteLine(ex);
      }
      catch (WithdrawNotSupportedException ex)
      {
        WriteLine(ex);
      }
      catch (DepositNotSupportedException ex)
      {
        WriteLine(ex);
      }
      catch (InsufficientFundsException ex)
      {
        WriteLine($"Data: {ex.Data}");

        WriteLine($"Insufficient Fund Exception Details: AccountNumber: {ex.AccountNumber}, CurrentBalance: {ex.CurrentBalance}, TransactionAmount: {ex.TransactionAmount}");

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

    //C:StepI
    public static void SMSAlert(int accountNumber, string transactionType, decimal transactionAmount, decimal newBalance)
    {
      string smsmessage = $"AccountNumber: {accountNumber}, TransactionType: {transactionType}, TransactionAmount: {transactionAmount}, NewBalance: {newBalance}";

      Printer.Print(smsmessage, "SMS Alert");
    }
    public static void EmailAlert(int accountNumber, string transactionType, decimal transactionAmount, decimal newBalance)
    {
      string emailmessage = $"AccountNumber: {accountNumber}, TransactionType: {transactionType}, TransactionAmount: {transactionAmount}, NewBalance: {newBalance}";

      Printer.Print(emailmessage, "Email Alert");
    }
  }
}

