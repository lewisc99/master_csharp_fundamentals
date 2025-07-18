// Suppos we create an object that uses unmanaged resources
var course = new Course() { Title = ".NET Fundamentals" };

Console.WriteLine($"Course title: {course.Title}");

// After we are done using it, we should make sure that
// Unmanaged resources are released:
course.Dispose();