using System;

namespace Delegates
{
  delegate void MessagePrinter(string message);

  class Program
  {
    static void Main(string[] args)
    {
      MessagePrinter printer = SurroundWithHyphens;
      printer += SurroundWithStars; // Add another method to the delegate

      MethodInvoker(printer, "Hello, World!");
    }


    // The method accepts a delegate of type MessagePrinter
    static void MethodInvoker(MessagePrinter printer, string message)
    {
      // We normally use ? because the delegate can be null
      printer?.Invoke(message);
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