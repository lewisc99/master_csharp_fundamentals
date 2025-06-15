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
      bool locked = false;

      // Marks the beginning of the critical section
      // Along with the locker object, we pass a reference
      // to our boolean variable. Its value will be set to true
      // when the lock is successfully acquired
      Monitor.Enter(locker, ref locked);

      try
      {
        // This critical section can only be executed by one thread at a time
        // Others will be waiting
        string original = new string(text);
        text = text.Insert(text.Length / 2, number.ToString());
        Console.WriteLine(text);
        text = original; // Restore original text
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error acquiring lock: {ex.Message}");
        return; // Exit if we can't acquire the lock
      }
      finally
      {
        // Always release the lock in the finally block - and if we acquired it
        // If we don't check if we acquired the lock, we might throw an exception
        // when trying to release it
        // This is important to avoid deadlocks
        // and ensure that the lock is released even if an exception occurs
        // in the critical section
        if (locked)
        {
          // Release the lock
          Monitor.Exit(locker);
        }
      }
    }
  }
}