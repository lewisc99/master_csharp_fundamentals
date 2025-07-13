using System;

var course = new Course() { Title = ".NET Fundamentals" };
course.DurationInWeeks = 8;

// GetCourseDuration has the dynamic return type
dynamic duration = course.GetCourseDuration("string");
Console.WriteLine($"Type: {duration.GetType()}, value: {duration}");

duration = course.GetCourseDuration("int");
Console.WriteLine($"Type: {duration.GetType()}, value: {duration}");
