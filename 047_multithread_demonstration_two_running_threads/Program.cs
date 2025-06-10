using System;
using System.Threading;

Thread.CurrentThread.Name = "Main Thread";


// We will create one new thread. Both the Main and our second thread will run the same method.

var secondThread = new Thread(Inform);
secondThread.Name = "Second Thread";

// Any other method would block the program flow until it is done running
secondThread.Start();

// However, since the previous line spings up a new thread,
// The following method call will start before secondThread is done executing.
Inform();

// This method prints a message 10 times.
void Inform()
{
  for (int i = 0; i < 10; i++)
  {
    Console.WriteLine($"I am executing from the {Thread.CurrentThread.Name} thread. Count: {i + 1}.");

  }
}