using var course = new Course() { Title = ".NET Fundamentals" };

Console.WriteLine($"Course object with title {course.Title} is created.");

// Now, the whole Main() is the scope of of the using construct.
// We can access the course variable
Console.WriteLine(course.Title);

