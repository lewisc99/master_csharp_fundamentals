
using System;
using System.Threading;
using System.Threading.Tasks;

var task = Task.Run(Print);
var task2 = Task.Run(() => { Console.WriteLine("Anonymous method inside a task"); });

task.Wait();
task2.Wait();


static void Print()
{
  Console.WriteLine("Executing inside a task");
}