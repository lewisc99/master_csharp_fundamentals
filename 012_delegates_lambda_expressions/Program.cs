using System;

namespace Lambdas
{
  delegate int MathOperation(int operand1, int operand2);

  class Program
  {
    static void Main(string[] args)
    {
      // Lambda expression
      MathOperation mathOperation = (operand1, operand2) => operand1 + operand2;

      Console.WriteLine(mathOperation(10, 5)); // Output: 15

      // Lambda expression
      mathOperation += (operand1, operand2) => operand1 - operand2;

      Console.WriteLine(mathOperation(10, 5)); // Output: 5
    }
  }
}