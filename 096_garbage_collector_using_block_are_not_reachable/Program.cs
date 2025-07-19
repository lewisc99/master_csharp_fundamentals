using (var course = new Course() { Title = ".NET Fundamentals" })
{
  Console.WriteLine($"Course object with title {course.Title} is created.");
}

// We can't reach the objects created in the using block
Console.WriteLine(course.Title);