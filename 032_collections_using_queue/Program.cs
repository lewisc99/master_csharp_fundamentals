// Let's add these people to our store queue
var customer1 = new Person() { Name = "Anna" };
var customer2 = new Person() { Name = "Patrick" };
var customer3 = new Person() { Name = "John" };
var customer4 = new Person() { Name = "Lily" };

// Queue<T>: T can be any type
var storeQueue = new Queue<Person>();
storeQueue.Enqueue(customer1);
storeQueue.Enqueue(customer2);
storeQueue.Enqueue(customer3);
storeQueue.Enqueue(customer4);

// All customers in the queue
Console.WriteLine("Customers in the queue:");
foreach (var customer in storeQueue)
{
  // shows a list of customers in the queue
  Console.WriteLine($"- {customer.Name}");
}

// Peek at the first customer in line
while (storeQueue.Count > 0)
{
  Console.WriteLine($"Next customer in line is {storeQueue.Peek().Name}.");
  Console.WriteLine($"{storeQueue.Dequeue().Name} paid and left.");
}

class Person
{
  public string Name { get; set; }
}