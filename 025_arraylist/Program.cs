using System;

// ArrayList class resides in this namespace
using System.Collections;

// As we can see, we don't have to provide the size
var points = new ArrayList();

// Add methods adds an item to the end of the list
points.Add(87);
points.Add(90);
points.Add(70);
points.Add(92);

// Count property stores the count of items in the list
Console.WriteLine($"Array has {points.Count} items inside.");


// RemoveAt removes an item at the given index
// In this case, we are removing the first item
points.RemoveAt(0);


// ArrayList has an indexer that allows us to
// interact with it just like with an array
Console.WriteLine($"The first item is now {points[0]}.");


Console.WriteLine($"Array has {points.Count} items inside.");


// ArrayList can be iterated using a foreach loop
foreach (var point in points)
{
  Console.WriteLine(point);
}