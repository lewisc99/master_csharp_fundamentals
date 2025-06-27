
var task = Task.Run(print);
var task2 = Task.Run(() => Console.WriteLine("Anonymous method inside a task"));

// As tasks run on thread pool threads, 
// a foreground thread must be running or else tasks will stop
Thread.Sleep(2000);

static void print()
{
  Console.WriteLine("Executing inside a task");
}