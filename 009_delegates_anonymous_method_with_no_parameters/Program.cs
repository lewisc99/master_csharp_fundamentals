using System;

namespace AnonymousMethods
{

  // Return type is void, accepts one parameter
  delegate void NotificationHandler(string notification);

  class Program
  {
    static void Main(string[] args)
    {
      // No parameters, even though the delegate accepts a string object
      // as a parameter, this delegate could be used to pass a string object
      NotifyUser("Battery low", delegate
      {
        // The anonymous method does not return anything (void)
        Console.WriteLine("Hard-coded notification");
      });

      // another example - with parameter
      NotifyUser("Battery low - with parameter", delegate (string notification)
      {
        // The anonymous method does not return anything (void)
        Console.WriteLine(notification);
      });
    }

    static void NotifyUser(string notification, NotificationHandler handler)
    {
      // Call the delegate
      handler(notification);
    }
  }
}
