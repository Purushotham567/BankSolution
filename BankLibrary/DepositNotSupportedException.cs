using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  public class DepositNotSupportedException : ApplicationException
  {
    public DepositNotSupportedException(string message) : base(message) { }
  }
}
