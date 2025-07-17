// Let's create an object of type Course
// It is eligible for collection once the method returns
CreateSomeObject();

// Manually Launch the garbage collector and wait for the process to complete
GC.Collect();
GC.WaitForPendingFinalizers();

static void CreateSomeObject()
{
  var course = new Course() { Title = ".NET Fundamentals" };
  Console.WriteLine($"Course: {course.Title}");
}