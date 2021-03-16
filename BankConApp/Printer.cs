using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConApp
{
  public static class Printer
  {
    public static void Print(string message, string header = null, string pattern = "-", int noOfPattern = 100)
    {
      int headerLength = 0;
      if (header != null)
      {
        headerLength = header.Length;
      }
      for (int i = 0; i < (noOfPattern-headerLength); i++)
      {
        Console.Write(pattern);
        if (i == ((noOfPattern-headerLength)/ 2))
        {
          Console.Write(header);
        }
      }
      Console.WriteLine($"\n{message}");
      for (int i = 0; i < noOfPattern; i++)
      {
        Console.Write(pattern);
      }
      Console.WriteLine();
    }
  }
}
