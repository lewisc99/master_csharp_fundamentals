
using (var course = new Course() { Title = ".NET Fundamentals" })
{
  Console.WriteLine($"Course object with title {course.Title} is created.");
  // Dispose() is called when existing the block
}

Console.WriteLine("End of Main()");
