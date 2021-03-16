using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace BankLibrary
{
  public class InsufficientFundsException : ApplicationException
  {
    private int _accountNumber;
    private decimal _currentBalance, _transactionAmount;

    public InsufficientFundsException(int accountNumber, decimal currentBalance, decimal transactionAmount, string message) : base(message) 
    {
      _accountNumber = accountNumber;
      _currentBalance = currentBalance;
      _transactionAmount = transactionAmount;

      // Log the details
      StreamWriter sWriter = new StreamWriter(@"../../../Funds.txt", true);
      string str = $"{_accountNumber}|{_currentBalance}|{_transactionAmount}|{DateTime.Now}";
      sWriter.WriteLine(str);
      sWriter.Flush();
      sWriter.Close();
    }

    public int AccountNumber { get { return _accountNumber; } }
    public decimal TransactionAmount { get { return _transactionAmount; } }
    public decimal CurrentBalance { get { return _currentBalance; } }

  }
}
