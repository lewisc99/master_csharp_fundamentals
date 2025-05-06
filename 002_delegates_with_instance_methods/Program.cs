namespace Delegates
{
  delegate void MessagePrinter();

  class Program
  {
    static void Main(string[] args)
    {
      Dog dog = new Dog("Buddy");
      Dog do2 = new Dog("Max");

      // attach the method to the delegate
      MessagePrinter messagePrinter = dog.Bark;
      messagePrinter += do2.Bark; // add another method to the delegate

      // invoke the delegate
      messagePrinter();
    }
  }
}