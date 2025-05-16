using System;

namespace Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      var footballMatch = new FootballMatch("Barcelona", "Real Madrid");

      // We can only attach a method to the event
      // We cannot assign a new delegate to the event
      // Subscribing to the event
      footballMatch.GoalScored += (scorer, team1Score, team2Score) =>
      {
        Console.WriteLine($"{scorer} scored. Current score is {team1Score}:{team2Score}.");
      };

      // Subscribing 
      footballMatch.GoalScored += PrintNewScoreDecorated;

      footballMatch.IncreaseTeam1Score();


      // Unsubscribing from the event
      footballMatch.GoalScored -= PrintNewScoreDecorated;

      footballMatch.IncreaseTeam1Score();

    }

    static void PrintNewScoreDecorated(string scorer, int team1Score, int team2Score)
    {
      Console.WriteLine("***********************************************************");
      Console.WriteLine($"GOOOOAL!!! {scorer} scores!!! {team1Score}:{team2Score}!!!");
      Console.WriteLine("***********************************************************");
    }
  }
}