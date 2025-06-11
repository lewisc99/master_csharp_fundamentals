using System;
using System.Threading;

// There are three ways to pass parameters to a method in a thread:

// 1. Create a ParameterizedThreadStart delegate object and add a method to this delegate
var parameterizedThreadStart = new ParameterizedThreadStart(PrintNumbers);
var thread = new Thread(parameterizedThreadStart);

// 2. Pass a method name directly
var thread2 = new Thread(PrintMessage);

// 3. Pass an anonymous method that conforms to the ParameterizedThreadStart delegate
var thread3 = new Thread((message) =>
        {
          Console.WriteLine(message);
        });

// PrintMessage() method has the same signature and return type as ParameterizedThreadStart delegate
static void PrintMessage(object message)
{
  Console.WriteLine("Hello World!");
}