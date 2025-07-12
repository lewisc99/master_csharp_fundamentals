using System;
using System.Reflection;

Type typeString = typeof(string);

Type[] implementedInterfaces = typeString.GetInterfaces();

Console.WriteLine($"{typeString.Name} implements {implementedInterfaces.Length} interfaces:");

foreach (var type in implementedInterfaces)
{
  Console.WriteLine(type.Name);
}