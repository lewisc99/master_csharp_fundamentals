using System;


public class Course : IDisposable
{
  private bool disposed = false;

  public string Title { get; set; }

  public void Dispose()
  {
    Dispose(true);

    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing)
  {
    if (disposed)
    {
      return;
    }

    if (disposing)
    {
      Console.WriteLine("Releasing managed resources.");
    }

    Console.WriteLine("Releasing unmanaged resources.");

    disposed = true;
  }

  ~Course()
  {
    Dispose(false);
  }
}