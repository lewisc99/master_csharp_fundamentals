using System;

namespace Delegates
{
  // Returns void and does not accept any parameters
  delegate void MessagePrinter();

  class Program
  {
    static void Main(string[] args)
    {
      // Declare a variable of the delegate type
      // and make it point to a method
      MessagePrinter printer = new MessagePrinter(PrintHelloWorld);

      // Instead of using a constructor, we can just initialize it
      // with a method pointer
      MessagePrinter printer2 = PrintHelloWorld;

      // Add another method to which the delegate will point to
      printer += PrintGoodBye;
      printer2 += PrintGoodBye;

      // Call the delegate
      printer();

      // Another way to call the delegate
      printer2.Invoke();
    }

    // Returns void and does not accept any parameters
    static void PrintHelloWorld()
    {
      Console.WriteLine("Hello World!");
    }

    // Returns void and does not accept any parameters
    static void PrintGoodBye()
    {
      Console.WriteLine("Good bye!");
    }
  }
}