using System;
public class MinLengthAttribute : Attribute
{
  public int MinLength { get; set; }
  public MinLengthAttribute() { }
  
  public MinLengthAttribute(int minLength)
  {
    this.MinLength = minLength;
  }
}