using System;

// 1st approach
Type typeInfoOnInteger = typeof(int);
Console.WriteLine(typeInfoOnInteger);

// 2nd approach
var stringObject = "Hello world!";
Type typeInfoOnString = stringObject.GetType();
Console.WriteLine(typeInfoOnString);

//  3nd approach
Type typeInfoOnBoolean = Type.GetType("System.Boolean");
Console.WriteLine(typeInfoOnBoolean);
