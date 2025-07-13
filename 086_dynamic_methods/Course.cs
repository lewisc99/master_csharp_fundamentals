public class Course
{
  public string Title { get; set; }

  public int DurationInWeeks { get; set; }

  // The method has dynamic return type
  public dynamic GetCourseDuration(string format)
  {
    // Depending on the value of format,
    // the return type will either be int or string
    if (format == "string")
    {
      return $"{DurationInWeeks} weeks";
    }

    else if (format == "int")
    {
      return DurationInWeeks;
    }

    else
    {
      return "Invalid format provided.";
    }
  }
}