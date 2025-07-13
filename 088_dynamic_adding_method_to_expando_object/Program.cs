using System;
using System.Dynamic;

dynamic car = new ExpandoObject();

car.Model = "Corolla";
car.Price = 15000;
car.Color = "Blue";

Console.WriteLine($"Model: {car.Model}");
Console.WriteLine($"Price: ${car.Price}");
Console.WriteLine($"Color: {car.Color}");

// Create a property of type Action (which is essentially a method)
car.Accelerate = new Action(() => { Console.WriteLine("Accelerating..."); });

// Call the delegate
car.Accelerate();