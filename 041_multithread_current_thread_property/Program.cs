using System;
using System.Threading;

// Gets the thread that is currently running
var currentThread = Thread.CurrentThread;

Console.WriteLine($"Current Thread ID: {currentThread.ManagedThreadId}");
Console.WriteLine($"Current Thread Name: {currentThread.Name ?? "No Name"}");

currentThread.Name = "MainThread";
Console.WriteLine($"Current Thread Name after setting: {currentThread.Name}");

