using System;
using System.Threading;
using System.Diagnostics;

Console.WriteLine("CPU-bound threading demo on a single-core CPU.");
// Set the processor affinity to a single core
// This will restrict the process to run on only one core
// if you comment this line, the process will run on all available cores
// This code below is for demonstration purposes only
// And will be useful if you want to test the performance of a single-core CPU
Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)1;


// Start 3 threads that will run concurrently

var stopwatch = Stopwatch.StartNew();

// Start 2 threads to simulate CPU work
Thread t1 = new Thread(() => DoHeavyWork("A"));
Thread t2 = new Thread(() => DoHeavyWork("B"));


t1.Start();
t2.Start();

// Join is used to wait for the threads to finish
// This will block the main thread until both threads complete
t1.Join();
t2.Join();

stopwatch.Stop();
Console.WriteLine($"\nTotal elapsed time: {stopwatch.Elapsed.TotalSeconds:F2} seconds");

static void DoHeavyWork(string label)
{
  Console.WriteLine($"Thread {label} started on core {Thread.GetCurrentProcessorId()}");

  long total = 0;

  // Simulate heavy CPU work by performing a large number of calculations
  for (long i = 0; i < 1_000_000_000; i++)
  {
    total += i % 3;
  }

  Console.WriteLine($"Thread {label} finished on core {Thread.GetCurrentProcessorId()} with total: {total}");
}