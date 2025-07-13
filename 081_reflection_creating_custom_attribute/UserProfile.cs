using System;

public class UserProfile
{
  // We want Username to be at least 10 characters
  [MinLength(10)]
  public string Username { get; set; }

  // We want Password to be at Least 15 characters
  [MinLength(15)]
  public string Password { get; set; }

}