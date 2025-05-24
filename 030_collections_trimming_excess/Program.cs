var numbers = new List<int>();
Console.WriteLine(numbers.Capacity); // 0

numbers.Add(17);
Console.WriteLine(numbers.Capacity); // 4

// Trimming the excess capacity
// This will reduce the capacity to the number of elements in the list
// In this case, it will be 1 since we have added only one element
numbers.TrimExcess();
Console.WriteLine(numbers.Capacity); // 1

// Adding more elements
numbers.Add(42);

// The capacity will increase again
// The new capacity will be the next power of 2 instead of 8,
// Because without trimming, the capacity is multiplied by 2.
// And each element is 4 bytes
// So the new capacity will be 2 * 4 = 8 without trimming
Console.WriteLine(numbers.Capacity); // 2