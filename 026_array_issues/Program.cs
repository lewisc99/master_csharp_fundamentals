using System;

// ArrayList class resides in this namespace
using System.Collections;

var points = new ArrayList();

// We have added 4 points
points.Add(87);
points.Add(90);
points.Add(70);
points.Add(92);

// Someone added a string item by mistake
points.Add("String? yes. we can add Strings");

// Now we want to calculate the average
int totalSum = 0;
foreach (var point in points)
{
  // We need to check if the item is an integer
  // before we can add it to the total sum
  totalSum += (int)point;
}

Console.WriteLine($"The average is {(double)totalSum / points.Count}.");
