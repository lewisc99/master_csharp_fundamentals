using System;
using System.Collections.Generic;
using Collections;

var positiveNumbers = new PositiveIntegerList();

positiveNumbers.Add(1);
positiveNumbers.Add(2);
positiveNumbers.Add(17);
positiveNumbers.Add(982);


// This is how foreach works
var enumerator = positiveNumbers.GetEnumerator();


while (enumerator.MoveNext())
{
  Console.WriteLine(enumerator.Current);
}


enumerator.Reset(); // Reset the enumerator to the start of the collection


Console.WriteLine("After reset");
Console.WriteLine("Iterating again...");
Console.WriteLine("=====================================");
// Now we can iterate again - instead of using the enumerator directly, we can use foreach
// This is the same as the above code, but using foreach
// This is how foreach works
foreach (var number in positiveNumbers)
{
  Console.WriteLine(number);
}