using System;

namespace AnonymousMethods
{
  delegate void MathOperation();

  class Program
  {
    static void Main(string[] args)
    {
      // Variables defined inside the Main method
      int number1 = 61;
      int number2 = 88;

      // Our anonymous method can access variables defined
      // in the context where the anonymous method is created
      MathOperation mathOperation = delegate
      {
        // Can access number1 and number2
        Console.WriteLine(number1 + number2);
      };

      mathOperation();
    }
  }
}
