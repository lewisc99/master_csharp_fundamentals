using System;

namespace Lambdas
{

  // Does not return anything
  // Does not accept any parameters
  delegate void MessagePrinter();
  class Program
  {
    static void Main(string[] args)
    {
      // Empty parantheses if no parameters
      // No return value

      MessagePrinter printer = () => Console.WriteLine("Hello, World!");
      printer += () => Console.WriteLine("Hello, Again!");

      // if you not add printer() to the end of the line, it will not execute
      // any of the methods
      printer(); // Output: Hello, World! Hello, Again!
    }
  }
}