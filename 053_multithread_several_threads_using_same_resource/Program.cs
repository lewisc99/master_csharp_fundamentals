using System;
using System.Threading;

namespace SynchronizingThreads
{
  class Program
  {
    static string text = "Microsoft";

    static void Main(string[] args)
    {
      var thread1 = new Thread(InsertNumber);
      var thread2 = new Thread(InsertNumber);
      var thread3 = new Thread(InsertNumber);

      thread1.Start(1);
      thread2.Start(2);
      thread3.Start(3);
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