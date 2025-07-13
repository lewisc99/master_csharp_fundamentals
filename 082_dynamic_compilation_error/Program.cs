var course = new Course() { Title = ".NET Fundamentals." };

// Duration property does not exist
// We will get an error during compilation
Console.WriteLine(course.Duration);