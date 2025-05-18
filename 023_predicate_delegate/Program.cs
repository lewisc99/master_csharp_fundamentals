using System;

namespace Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      Predicate<int> isEven = delegate (int x)
          {
            return x % 2 == 0;
          };

      // Predicate returns a bool value
      bool sevenIsEven = isEven(7);

      if (sevenIsEven)
      {
        Console.WriteLine("7 is even");
      }
      else
      {
        Console.WriteLine("7 is odd");
      }
    }
  }
}