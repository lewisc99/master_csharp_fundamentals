using System;

// List<T> resides in this namespace
using System.Collections.Generic;

var listOfIntegers = new List<int>();

// We can add items individually
listOfIntegers.Add(57);
listOfIntegers.Add(82);

// We can also add another collection
listOfIntegers.AddRange(new int[] { 24, 12, 56, 23, 78 });

// Gets the number of items
Console.WriteLine($"There are {listOfIntegers.Count} items in our list.");

// Indexers are present
Console.WriteLine($"The 5th number is {listOfIntegers[4]}");


// We can remove an item at a specific index
listOfIntegers.RemoveAt(5);

// We can remove all items that match a condition
// Remember predicates?
// In this case, we are removing numbers less than 30.
listOfIntegers.RemoveAll(x => x < 30);

Console.Write($"Items left: {listOfIntegers.Count}.\n");
