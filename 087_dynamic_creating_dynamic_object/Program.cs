using System;
using System.Dynamic;

// We instatiate the ExpandoObject
dynamic car = new ExpandoObject();

// Add members
car.Model = "Corolla";
car.Price = 1500;
car.Color = "Blue";

// User the members
Console.WriteLine($"Model: {car.Model}");
Console.WriteLine($"Price: ${car.Price}");
Console.WriteLine($"Color: {car.Color}");