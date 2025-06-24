using System;
using System.Threading;


ThreadPool.QueueUserWorkItem(Print);

// Sleep for a while to allow the thread pool to complete its work
Thread.Sleep(2000);

static void Print(object? state)
{
  Console.WriteLine("Hello from the thread pool!");
}
// This code demonstrates how to use the thread pool to run a method asynchronously.
// The main thread sleeps for a short time to allow the thread pool to complete its work before
// the program terminates. This prevents the program from exiting immediately, which would
// otherwise terminate the thread pool and any threads it has created.