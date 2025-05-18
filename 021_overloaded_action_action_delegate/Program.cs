namespace Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      // Accepts two integers as parameters.
      // We can instantiate a delegate with up to 16 parameters.
      // Action<int, string, bool, int, int> ...
      Action<int, int> mathOperation;

      mathOperation = (x, y) => Console.WriteLine(x + y);
      mathOperation += (x, y) => Console.WriteLine(x * y);

      mathOperation(3, 4);
    }
  }
}