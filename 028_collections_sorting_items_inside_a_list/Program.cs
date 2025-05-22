using System;
using System.Collections.Generic;

// Instantiating using an initializer
var numbers = new List<int>()
            {
                1, 78, 0, -5, 25, 31, 90, 23, 67, 53
            };


// Sort in a ascending order
numbers.Sort();

PrintList<int>(numbers);

// Searching for 31
// Returns 0-based index or a negative number if not found
// BinarySearch requires the list to be sorted
var indexOf31 = numbers.BinarySearch(31);


if (indexOf31 >= 0)
  Console.WriteLine($"31 is located at index {indexOf31}.");
else
  Console.WriteLine("Number was not found.");

static void PrintList<T>(List<T> list)
{
  foreach (var item in list)
  {
    Console.Write(item.ToString() + " ");
  }

  Console.WriteLine();
}