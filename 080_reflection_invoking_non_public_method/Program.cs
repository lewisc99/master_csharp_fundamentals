using System;
using System.Reflection;

namespace ReflectionIntroduction
{
  class Program
  {
    static void Main(string[] args)
    {
      string fruits = "apple,banana,orange";
      Type type = typeof(string);

      // Look for non-public methods
      MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

      Console.WriteLine($"Non-public methods of {type.Name}:");

      foreach (var methodInfo in methodInfos)
      {
        Console.WriteLine(methodInfo.Name);
      }


      // There's SplitInternal method, we will call it despite it's internal and not accessible by us
      MethodInfo splitInternalMethod = methodInfos[3];
      Console.WriteLine("\nCalling the SplitInternal() method..");

      // We call the method using Invoke(). If it is an instance method, then the first parameter
      // is an object on which the method will be called. We pass the parameters as an object array (object[])
      var result = splitInternalMethod.Invoke(fruits, new object[] { ",", new string[] { "," }, Int32.MaxValue, StringSplitOptions.None });

      Console.WriteLine("Fruits: ");
      if (result is string[])
      {
        foreach (var item in result as string[])
        {
          Console.WriteLine(item);
        }
      }
    }
  }
}