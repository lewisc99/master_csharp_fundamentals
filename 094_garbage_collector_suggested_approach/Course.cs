public class Course : IDisposable
{

  // The field will store whether or not the object was disposed
  private bool disposed = false;

  public string Title { get; set; }

  public void Dispose()
  {
    // In this method, we will release both managed and unmanaged resources
    Dispose(true);

    // We instruct the garbage collector not to call the destructor,
    // Because we already handled both managed and unmanaged resources
    GC.SuppressFinalize(this);
  }

  private void Dispose(bool disposing)
  {
    // If the object is already disposed, nothing to do
    if (disposed)
    {
      return;
    }

    if (disposing)
    {
      // Release managed resources (links to other internal objects, for instance)
      Console.WriteLine("Releasing 'managed' resources");
    }

    // Release unmanaged resources
    Console.WriteLine("Releasing 'unmanaged' resources.");

    // Set the disposed flag to true
    disposed = true;
  }

  ~Course()
  {
    // Inside the destructor, we call Dispose(false),
    // because we do not want to release managed resources.
    // The reason is that, by the time the garbage collector calls the destructor,
    // they may have been already released
    Dispose(false);
  }
}