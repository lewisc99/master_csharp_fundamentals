using System;
using System.Reflection;

Type typeInfoOnString = typeof(string);
var privateInstanceFields = typeInfoOnString.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

Console.WriteLine($"{typeInfoOnString.Name} has these private instance fields:");

foreach (var fieldInfo in privateInstanceFields)
{
  Console.WriteLine($"{fieldInfo.Name}");
}