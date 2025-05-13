using System;

namespace Lambdas
{

  // Delegate with a parameter decorated with ref
  // The parameter is passed by reference
  delegate void IncrementOperation(ref int number);
  class Program
  {
    static void Main(string[] args)
    {
      // We must write the parameter types now
      // ref in this case means that the parameter is passed by reference
      // reference in a easy way is like a pointer to the variable
      // So if we change the value of the parameter, it will change the value of the variable
      // in the main method
      IncrementOperation incrementor = (ref int number) => number++;

      int x = 10;

      incrementor(ref x); // Output: 11
      incrementor(ref x); //  
      Console.WriteLine(x); // Output: 11
    }
  }
}