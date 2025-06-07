// Simulating multithreading on a single-core processor
using System;
using System.ComponentModel;
using System.Threading;

Console.WriteLine("Simulating multithreading on a single-core processor...");

// Start 2 threads
for (int i = 1; i <= 2; i++)
{
  int threadNumber = i;

  Thread thread = new Thread(() => DoWork(threadNumber));
  thread.Start();
}

static void DoWork(int threadNumber)
{
  Console.WriteLine($"Thread {threadNumber} started.");

  // Simulate some work
  for (int i = 0; i < 2; i++)
  {
    Console.WriteLine($"Thread {threadNumber} is working on step {i + 1} at {DateTime.Now:HH:mm:ss.fff}");
    // Simulate work by sleeping 
    Thread.Sleep(1000); // Simulating work by sleeping
  }

  Console.WriteLine($"Thread {threadNumber} finished.");
}