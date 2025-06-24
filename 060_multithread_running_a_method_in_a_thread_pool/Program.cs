using System;
using System.Threading;

ThreadPool.QueueUserWorkItem(Print);

static void Print(object? state)
{
  Console.WriteLine("Hello from the thread pool!");
}
