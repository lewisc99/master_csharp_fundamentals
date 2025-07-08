using System;
using System.Threading;
using System.Threading.Tasks;

// We execute a potentially long-running method in the background
// We do not need the result yet
Task<int> task = SquareAsync(5439);


Console.WriteLine("The Main() method continues to run.");

// When we need the result of the calculation, we block the current thread and wait for it
task.Wait();
int result = task.Result;
Console.WriteLine($"Result: {result}.");


// The method will return an integer value
static async Task<int> SquareAsync(int n)
{
  // Task encapsulates an anonymous method that returns an int
  var task = Task.Run(() => { return n * n; });

  Console.WriteLine("Calculation started...");

  // The await statement waits for the result of the running task
  int result = await task;

  // We just return an integer
  return result;
}