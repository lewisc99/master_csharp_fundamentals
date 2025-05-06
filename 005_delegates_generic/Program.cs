using System;

namespace Delegates
{

  class Program
  {
    // Generic delegate
    // delegate T2 means, that the return type of the delegate is T2,
    delegate T2 MathOperator<T1, T2>(T1 operador1, T1 operador2);

    static void Main(string[] args)
    {
      // Instantiating a generic delegate
      MathOperator<int, long> operator1 = Adder;
      MathOperator<int, double> operator2 = Divider;

      long sum = operator1(10, 20);
      double divisionResult = operator2(7, 2);

      Console.WriteLine(sum);
      Console.WriteLine(divisionResult);
    }

    static long Adder(int firstNumber, int secondNumber)
    {
      return firstNumber + secondNumber;
    }

    static double Divider(int firstNumber, int secondNumber)
    {
      return (double)firstNumber / secondNumber;
    }
  }
}