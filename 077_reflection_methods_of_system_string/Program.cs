using System;
using System.Reflection;

// We first obtain type information on string
Type typeInfoOnString = typeof(string);

// The array contains MethodInfo objects, each of which has information on the methods of 
// a string type
MethodInfo[] stringMethods = typeInfoOnString.GetMethods();

Console.WriteLine($"{typeInfoOnString.Name} has these methods:");

// We iterate the array and print out the information regarding the method
foreach (var methodInfo in stringMethods)
{
  ParameterInfo[] parameterInfos = methodInfo.GetParameters();

  string parameters = ParameterInfosToString(parameterInfos);

  Console.WriteLine($"{methodInfo.Name}({parameters}) -> returns {methodInfo.ReturnType}.");
}


// This method gives the list of method parameters in a readable form
static string ParameterInfosToString(ParameterInfo[] parameterInfos)
{
  string parameters = "";

  for (int i = 0; i < parameterInfos.Length - 1; i++)
  {
    parameters += $"{parameterInfos[i].ParameterType.Name} {parameterInfos[i].Name}, ";
  }

  if (parameterInfos.Length > 0)
  {
    int lastIndex = parameterInfos.Length - 1;
    parameters += $"{parameterInfos[lastIndex].ParameterType.Name} {parameterInfos[lastIndex].Name}";
  }

  return parameters;

}