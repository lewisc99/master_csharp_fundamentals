
using System;
using System.Threading;

var thread = new Thread(RepeatSeveralTimes);

var parameters = new MultiplierParameters() { Text = "Bingo", Multiplier = 5 };

thread.Start(parameters);


// We want to pass two parameters: string and int
// We create a new class with two properties of type string and int
static void RepeatSeveralTimes(object textMultiplier)
{
  if (textMultiplier is MultiplierParameters)
  {
    var parameters = (MultiplierParameters)textMultiplier;
    var output = "";

    for (int i = 0; i < parameters.Multiplier; i++)
    {
      output += parameters.Text + " ";
    }

    Console.WriteLine(output);
  }
}

public class MultiplierParameters
{
  public string Text { get; set; }
  public int Multiplier { get; set; }
}