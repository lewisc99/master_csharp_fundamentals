using System;

namespace Lambdas
{

  delegate void IncrementOperation(ref int number);
  class Program
  {
    static void Main(string[] args)
    {
      int x = 10;

      ModifyNumber(ref x, (ref int number) => number++); // Output: 11
      ModifyNumber(ref x, (ref int number) => number += 5); // Output: 16
      ModifyNumber(ref x, (ref int number) => number *= 2); // Output: 32
      ModifyNumber(ref x, (ref int number) => number -= 10); // Output: 22

      Console.WriteLine(x); // Output: 22 because the last operation was to subtract 10 from 32
    }

    static void ModifyNumber(ref int number, IncrementOperation incrementor)
    {
      incrementor(ref number);
    }
  }
}