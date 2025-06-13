using System;

namespace SynchronizingThreads
{
  class Program
  {
    static string text = "Microsoft";

    static void Main(string[] args)
    {
      Console.WriteLine($"Value of `text` before calling the InsertNumber() method: {text}.");
      InsertNumber(10);
      Console.WriteLine($"Value of `text` after calling the InsertNumber() method: {text}.");
    }

    static void InsertNumber(object number)
    {
      if (number is int)
      {
        string original = new string(text);
        text = text.Insert(text.Length / 2, number.ToString());
        Console.WriteLine(text);
        text = original;
      }
    }
  }
}