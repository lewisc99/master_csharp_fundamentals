using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingTasks
{
  class Program
  {
    static void Main(string[] args)
    {
      var task = new Task(Print);
      var task2 = new Task(() => { Console.WriteLine("Anonymous method inside a task"); });

      task.RunSynchronously();

      // Waits until the first task finishes
      task2.RunSynchronously();

      // The Main() method does not end until task2 finishes
    }

    static void Print()
    {
      Console.WriteLine("Executing inside a task");
    }
  }
}