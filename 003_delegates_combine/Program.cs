using System;

namespace Delegates
{
  delegate void MessagePrinter(string message);

  class Program
  {
    static void Main(string[] args)
    {
      // Create delegates of the same type
      MessagePrinter messagePrinter1 = SurroundWithHyphens;
      MessagePrinter messagePrinter2 = SurroundWithStars;
      MessagePrinter messagePrinter3 = SurroundWithStars;

      // combine the delegates
      MessagePrinter combinedPrinter = messagePrinter1 + messagePrinter2 + messagePrinter3;

      // Call the combined delegate
      combinedPrinter("Hello, World!");
    }
    static void SurroundWithStars(string message)
    {
      Console.WriteLine($"***{message}***");
    }

    static void SurroundWithHyphens(string message)
    {
      Console.WriteLine($"---{message}---");
    }
  }


}