using System;
using System.Threading;

class Program
{
  private static int balance = 0;
  private static readonly object locker = new object();

  static void Deposit()
  {
    for (int i = 0; i < 1000; i++)
    {
      lock (locker) // Critical section
      {
        balance++; // safe to update
      }
    }
  }

  static void Main()
  {
    Thread[] threads = new Thread[10];

    for (int i = 0; i < threads.Length; i++)
    {
      threads[i] = new Thread(Deposit);
      threads[i].Start();
    }

    foreach (Thread t in threads)
    {
      t.Join(); // Wait for all threads
    }


    // After all threads have completed, print the final balance
    // The lock ensures that the balance is updated safely
    // So basically, the final balance should be 10000
    // because 10 threads each deposit 1000 (1000 * 10 = 10000)
    
    Console.WriteLine($"Final balance using lock: {balance}");
  }
}
