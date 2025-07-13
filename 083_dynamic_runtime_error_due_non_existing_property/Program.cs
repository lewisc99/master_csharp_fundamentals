using System;

// We declare the variable using the dynamic keyword
dynamic course = new Course() { Title = ".NET Fundamentals" };

// Program compiles and runs because there is no compile-time checking
// for dynamic objects
Console.WriteLine("Program  started running");

// However, because there is no Duration property,
// The program fails during runtime
Console.WriteLine(course.Duration);