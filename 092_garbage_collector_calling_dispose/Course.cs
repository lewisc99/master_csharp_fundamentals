// Implement the IDisposable interface
public class Course : IDisposable
{
  public string Title { get; set; }

  ~Course()
  {
    Console.WriteLine($"Course object with title {Title} claimed by the garbage collector.");
  }

  // We implement this method
  public void Dispose()
  {
    Console.WriteLine("Releasing unmanaged resources...");
  }

}