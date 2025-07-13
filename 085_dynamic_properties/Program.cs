var course = new Course() { Title = ".NET Fundamentals" };

// We set the value of the Duration property to an int object first
course.Duration = 8; // 8 weeks
Console.WriteLine($"Duration property type: {course.Duration.GetType()}, value: {course.Duration}.");

// Now we set the value to a string object
course.Duration = "8 Weeks";
Console.WriteLine($"Duration property type: {course.Duration.GetType()}, value: {course.Duration}.");
