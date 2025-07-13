using System;
using System.Dynamic;

namespace DynamicLanguageRuntime
{
  class Program
  {
    static void Main(string[] args)
    {
      dynamic car = new ExpandoObject();

      car.Model = "Corolla";
      car.Price = 15000;
      car.Color = "Blue";

      Console.WriteLine($"Model: {car.Model}");
      Console.WriteLine($"Price: ${car.Price}");
      Console.WriteLine($"Color: {car.Color}");

      car.Accelerate = new Action(() => { Console.WriteLine("Accelerating..."); });

      car.Accelerate();

      // The delegate returns an integer value
      car.GetFuelEconomy = new Func<int>(() => { return 30; });

      // Call the delegate and store the result in a variable
      int corollaFuelEconomy = car.GetFuelEconomy();

      Console.WriteLine($"Corolla's range is {corollaFuelEconomy} miles per gallon.");
    }
  }
}