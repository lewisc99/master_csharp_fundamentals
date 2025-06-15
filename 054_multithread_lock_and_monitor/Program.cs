class Program
{
  static string text = "Microsoft";

  // Dummy object that will server as a locker
  private static object locker = new object();

  private static void Main(string[] args)
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
      // We enclose the part that users a common resource with the lock block
      lock (locker)
      {
        // This critical section can only be executed by one thread at a time
        // Others will be waiting
        string original = new string(text);
        text = text.Insert(text.Length / 2, number.ToString());
        Console.WriteLine(text);
        text = original; // Restore original text
      }
    }
  }
}