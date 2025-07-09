using System.Reflection;

Type typeInfoOnString = typeof(string);

Assembly stringAssembly = typeInfoOnString.Assembly;
AssemblyName stringAssemblyName = stringAssembly.GetName();

Console.WriteLine($"Assembly name: {stringAssemblyName.Name}");
Console.WriteLine($"Assembly version: {stringAssemblyName.Version}");