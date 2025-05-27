var stackOfInts = new Stack<int>();

stackOfInts.Push(42);
PrintLastPushed<int>(stackOfInts);
PrintStackCount<int>(stackOfInts);

stackOfInts.Push(68);
PrintLastPushed<int>(stackOfInts);
PrintStackCount<int>(stackOfInts);

stackOfInts.Push(30);
PrintLastPushed<int>(stackOfInts);
PrintStackCount<int>(stackOfInts);

// 30 is the last pushed item, // so it will be the first one popped
Console.WriteLine("Popping the last item from the stack...");
var lastPopped = stackOfInts.Pop();
Console.WriteLine($"Popped {lastPopped} from the stack.");
PrintStackCount<int>(stackOfInts);


static void PrintLastPushed<T>(Stack<T> stack)
{
  // Peek reads without removing
  Console.WriteLine($"Placed {stack.Peek()} at the top of the stack.");
}

static void PrintStackCount<T>(Stack<T> stack)
{
  Console.WriteLine($"There are {stack.Count} items in the stack.");
}