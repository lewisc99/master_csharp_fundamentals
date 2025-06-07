using System;
using System.Threading;

// Demonstrates the properties of the Thread class
var thread = Thread.CurrentThread;
thread.Name = "MainThread";
Console.WriteLine($"Thread ID: {thread.ManagedThreadId}");
Console.WriteLine($"Thread Name: {thread.Name}");
Console.WriteLine($"Is Thread Pool Thread: {thread.IsThreadPoolThread}");
Console.WriteLine($"Thread State: {thread.ThreadState}");
Console.WriteLine($"Priority: {thread.Priority}");
Console.WriteLine($"Is Background Thread: {thread.IsBackground}");
Console.WriteLine($"Thread Culture: {thread.CurrentCulture}");
Console.WriteLine($"Thread Execution Context: {thread.ExecutionContext}");

Console.WriteLine($"Thread Apartment State: {thread.GetApartmentState()}");
Console.WriteLine($"Thread Is Alive: {thread.IsAlive}");