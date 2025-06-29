using System;
using System.Threading;
using System.Threading.Tasks;

Parallel.Invoke(PrintFirst, PrintSecond, PrintThird);

static void PrintFirst()
{
  Console.WriteLine("Started to run first.");
}

static void PrintSecond()
{
  Console.WriteLine("Started to run second.");
}

static void PrintThird()
{
  Console.WriteLine("Started to run third.");
}