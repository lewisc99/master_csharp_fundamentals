using System;
using System.Threading;
using System.Threading.Tasks;

var task = Task.Factory.StartNew(Print);
var task2 = Task.Factory.StartNew(() => { Console.WriteLine("Anonymous method inside a task"); });

// As tasks run on thread pool threads, 
// a foreground thread must be running or else tasks will stop
Thread.Sleep(2000);

static void Print()
{
  Console.WriteLine("Executing inside a task");
}