using System;

namespace Lambdas
{

  delegate int IncrementOperation(int number);
  class Program
  {
    static void Main(string[] args)
    {
      // No parantheses became there is only one parameter
      IncrementOperation increment = number => number + 1;

      Console.WriteLine(increment(5)); // Output: 6
    }
  }
}