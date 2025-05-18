namespace Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      // Accept an integer as a parameter
      Action<int> incrementor;


      incrementor = (x) => Console.WriteLine(x + 1);
      incrementor += (x) => Console.WriteLine(x + 7);

      incrementor(3);
    }
  }
}