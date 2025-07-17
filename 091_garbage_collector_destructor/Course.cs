public class Course
{
  public required string Title { get; set; }

  ~Course()
  {
    Console.WriteLine($"Course object with title {Title} claimed by the garbage collector.");
  }
}