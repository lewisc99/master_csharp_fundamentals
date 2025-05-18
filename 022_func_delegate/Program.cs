using System;

namespace Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      // Accepts no parameters and returns an int.
      Func<int> numberGenerator;

      // Accepts a string and returns an int
      // It can go up to 16 type parameters
      // The last one will be the return type
      Func<string, int> charCounter;

      numberGenerator = () => 0;
      charCounter = (word) => word.Length;

      Console.WriteLine(numberGenerator());
      Console.WriteLine(charCounter("Hello World!"));

      // Accepts no parameters and returns an int.
      Func<int> func = () => 42;
      // Accepts one parameter and returns a string.
      Func<int, string> func2 = (x) => x.ToString();
      // Accepts two parameters and returns a string.
      Func<int, int, string> func3 = (x, y) => (x + y).ToString();
      // Accepts three parameters and returns a string.
      Func<int, int, int, string> func4 = (x, y, z) => (x + y + z).ToString();
    }
  }
}