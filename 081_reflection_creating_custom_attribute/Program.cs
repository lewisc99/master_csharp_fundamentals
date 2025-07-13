using System;
using System.Reflection;

namespace CustomAttributes
{
  class Program
  {
    static void Main(string[] args)
    {
      var profile = new UserProfile { Username = "longusername", Password = "somepasswordthatisatleas15characterslong" };
      var stringLengthsAreValid = ValidateStringLength(profile);

      Console.WriteLine($"All string properties meet minimum length requirements: {stringLengthsAreValid}.");
    }

    // Returns true if properties of obj marked with MinLengthAttribute have the length >= MinLength
    static bool ValidateStringLength(object obj)
    {
      Type type = obj.GetType();
      var properties = type.GetProperties();

      foreach (var property in properties)
      {
        object[] attributes = property.GetCustomAttributes(false);

        foreach (var attribute in attributes)
        {
          if (attribute is MinLengthAttribute)
          {
            var minLength = ((MinLengthAttribute)attribute).MinLength;

            if (property.PropertyType == typeof(string))
            {
              var propertyValue = (string)property.GetValue(obj);
              return propertyValue.Length >= minLength;
            }
          }
        }
      }

      return true;
    }
  }
}