using System;
using System.Threading;
using System.Threading.Tasks;

// Starts executing the PrintAsync() method without blocking the current thread
Task task = PrintAsync();

// Whenever we need to wait for the task to complete,
// We can call the Wait() method, which blocks the current thread.
task.Wait();

// Async methods have the async modified
static async Task PrintAsync() // Good practice to name async method accordinly
{
  // Async methods have one or several awaits statements
  Task task = Task.Run(() => Console.WriteLine("Hello async world!"));

  // The method continues to run without waiting for the task to be completed
  Console.WriteLine("Hello world");

  // Now that we reached the end of the method, we can wait for the result of the task
  await task;
}