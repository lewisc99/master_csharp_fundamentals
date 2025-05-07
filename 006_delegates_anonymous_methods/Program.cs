using System;

namespace AnonymousMethods
{

  class Program
  {
    delegate void MessagePrinter();

    static void Main(string[] args)
    {
      // This delegate will have the reference
      // of the anonymous method 
      // anonymous method is basically a method without a name
      // and without a return type
      MessagePrinter printer = delegate ()
      {
        Console.WriteLine("Hello, World!");
      };

      printer(); // Call the delegate to execute the anonymous method
    }
  }
}