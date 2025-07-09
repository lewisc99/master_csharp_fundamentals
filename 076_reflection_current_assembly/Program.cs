using System;
using System.Reflection;

// The Program class is the one we are working on
Type typeInfoOnProgram = typeof(Program);

Assembly programAssembly = typeInfoOnProgram.Assembly;
AssemblyName programAssemblyName = programAssembly.GetName();

Console.WriteLine($"Assembly name: {programAssemblyName.Name}");
Console.WriteLine($"Assembly version: {programAssemblyName.Version}");