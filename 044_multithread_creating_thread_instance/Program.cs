using System;
using System.Threading;

// The are three ways t pass a parameterless method to a thread constructor:

// 1. Create a ThreadStart delegate object and add a method to this delegate
var threadStart = new ThreadStart(PrintHelloWorld);
var thread = new Thread(threadStart);

// 2. Pass a method directly to the Thread constructor
var thread2 = new Thread(PrintHelloWorld);

// 3. Use a lambda expression to pass a method to the Thread constructor
var thread3 = new Thread(() => PrintHelloWorld());

// 4. Pass an anonymous method that conforms to the ThreadStart delegate
var thread4 = new Thread(() =>
{
  Console.WriteLine("4 Thread - Hello from an anonymous method!");
});


static void PrintHelloWorld()
{
  Console.WriteLine("Hello, World!");
}