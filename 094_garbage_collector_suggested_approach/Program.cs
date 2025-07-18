Course course = null;

try
{
  course = new Course() { Title = ".NET Fundamentals" };
  Console.WriteLine($"Course title: {course.Title}");
}
finally
{
  course?.Dispose();
}