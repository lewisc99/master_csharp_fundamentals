using System;

namespace AnonymousMethods
{
  delegate int MathOperation(int operand1, int operand2);

  class Program
  {
    static void Main(string[] args)
    {
      // Example of an anonymous method that returns a value
      // No parameters, even though the delegate accepts two int objects
      // as parameters, this delegate could be used to pass two int objects
      // as parameters
      // The delegate is defined to return an int value
      MathOperation mathOperation = delegate (int operand1, int operand2)
      {
        return operand1 + operand2;
      };

      // Example Addition - with parameter
      int result = mathOperation(5, 10);
      Console.WriteLine($"Result of addition: {result}");

      // Another example Multiplication - with parameter
      mathOperation += delegate (int operand1, int operand2)
      {
        return operand1 * operand2;
      };

      // Call the delegate
      result = mathOperation(5, 10);
      Console.WriteLine($"Result of multiplication: {result}");

      // Another example Subtraction - with parameter
      mathOperation += delegate (int operand1, int operand2)
     {
       return operand1 - operand2;
     };

      // Call the delegate
      result = mathOperation(5, 10);
      Console.WriteLine($"Result of subtraction: {result}");


      // Another example Division - with parameter
      mathOperation += delegate (int operand1, int operand2)
      {
        return operand1 / operand2;
      };

      // Call the delegate
      result = mathOperation(30, 10);
      Console.WriteLine($"Result of division: {result}");
    }
  }
}
