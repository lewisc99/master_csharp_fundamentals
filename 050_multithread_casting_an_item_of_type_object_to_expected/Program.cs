using System;
using System.Threading;

var thread = new Thread(Divider);
var thread2 = new Thread(Divider);

// We pass an int value to the thread
thread.Start(5623);

// Our method accepts a parameter of type object
static void Divider(object number)
{
  // We want double or int items to be passed.
  // We check before making any operations
  if (number is double || number is int)
  {
    // If the parameter is of type double or int,
    // we perform the calculation
    var result = Convert.ToDouble(number) / 2;
    Console.WriteLine(result);
  }
  else
  {
    Console.WriteLine("Parameter must be of type int or double.");
  }
}