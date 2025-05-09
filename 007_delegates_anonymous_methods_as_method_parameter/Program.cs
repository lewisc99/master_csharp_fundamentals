using System;

namespace AnonymousMethods
{

  // Our delegate
  delegate void NotificationHandler(string notification);

  class Program
  {
    static void Main(string[] args)
    {
        // Instead of creating an instance of the delegate, 
        // we can use an anonymous method directly in the method call
        NotifyUser("You have a new message!", delegate (string notification) {
            Console.WriteLine(notification);
        });
    }

    // This method accepts a delegate as a parameter
    static void NotifyUser(string notification, NotificationHandler handler)
    {
      // Call the delegate
      handler(notification);
    }
  }
}
