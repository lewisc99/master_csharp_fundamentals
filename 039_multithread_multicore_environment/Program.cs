// Create a multithreaded application that runs on multiple cores in a easy way to understand way.
using System;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("Starting multithreaded application...");

// Create and start 2 threads
for (int i = 1; i <= 2; i++)
{
  int threadNum = i;
  Thread thread = new Thread(() => DoWork(threadNum));
  thread.Start();
}

Console.WriteLine("All threads started. Waiting for completion...");

static void DoWork(int threadNumber)
{
  for (int i = 1; i <= 3; i++)
  {
    Console.WriteLine($"Thread {threadNumber} is working on iteration {i}...");
    Thread.Sleep(1000); // Simulate work by sleeping for 1 second
  }

  Console.WriteLine($"Thread {threadNumber} has completed its work.");
}