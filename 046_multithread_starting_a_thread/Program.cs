using System;
using System.Threading;

var threadStart = new ThreadStart(PrintHelloWorld);

var thread = new Thread(threadStart);

var thread2 = new Thread(PrintHelloWorld);

var thread3 = new Thread(() => Console.WriteLine("Hello from anonymous method!"));

// Start the threads
thread.Start();
thread2.Start();
thread3.Start();


static void PrintHelloWorld()
{
  Console.WriteLine("Hello World!");
}