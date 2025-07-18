using System;

Course course = null;

try
{
  // All the work with the object goes inside the try block
  course = new Course() { Title = ".NET Fundamentals" };

  Console.WriteLine($"Course title: {course.Title}");
}
finally
{
  // In this block, we first check if the object is not null
  // and then call the Dispose() method
  course?.Dispose();
}