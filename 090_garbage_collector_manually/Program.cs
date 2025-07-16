using System;

namespace GarbageCollector
{
  class Program
  {
    static void Main(string[] args)
    {
      string first = "First object";
      string second = "Second object";
      string third = "Third object";
      string fourth = "Fourth object";

      // Let's see generations of the objects
      Console.WriteLine(GC.GetGeneration(first));
      Console.WriteLine(GC.GetGeneration(second));
      Console.WriteLine(GC.GetGeneration(third));
      Console.WriteLine(GC.GetGeneration(fourth));

      // Now, we will delete references from some of them
      second = null;
      fourth = null;

      // Let's start the garbage collection and wait until it finishes
      GC.Collect(0, GCCollectionMode.Forced);
      GC.WaitForPendingFinalizers();

      Console.WriteLine("Survived --------------");
      // Let's check the generation of those who survived
      Console.WriteLine(GC.GetGeneration(first));
      Console.WriteLine(GC.GetGeneration(third));
    }
  }
}