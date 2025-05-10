using System;

namespace AnonymousMethods
{
  delegate void MessagePrinter();

  class Program
  {
    static void Main(string[] args)
    {
      // Since the anonymous method doest not accept any parameters, we can omit the parameter list
      MessagePrinter printer = delegate
      {
        Console.WriteLine("Hello, World!");
      };

      // Call the delegate
      printer();
    }
  }
}
