using System;
using System.Threading;

var threadStart = new ThreadStart(PrintHelloWorld);

var thread = new Thread(threadStart);

var thread2 = new Thread(PrintHelloWorld);

var thread3 = new Thread(() => Console.WriteLine("Hello from anonymous method!"));


// ThreadState property stores the state of the thread
Console.WriteLine(thread.ThreadState);

static void PrintHelloWorld()
{
  Console.WriteLine("Hello, World!");
}