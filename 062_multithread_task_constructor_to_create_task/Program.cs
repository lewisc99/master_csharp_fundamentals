using System;
using System.Threading;
using System.Threading.Tasks;

// We can pass a name of the method conforms to the Action delegate
var task = new Task(Print);
task.Start();

// We can pass an anonymous method
var task2 = new Task(() => { Console.WriteLine("Anonymous method inside a task"); });

task2.Start();

// As tasks run on thread pool threads,
// A foreground thread must be running or else tasks will stop.
Thread.Sleep(2000);

static void Print()
{
  Console.WriteLine("Executing inside a task");
}