using System;

namespace Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      var footballMatch = new FootballMatch("Team A", "Team B");

      // We can only attach a method to the event
      // or unregister it
      // No other actions are possible
      footballMatch.GoalScored += (scoringTeam, team1Score, team2Score) =>
      {
        Console.WriteLine($"{scorer} scored. Current score is {team1Score}:{team2Score}.");
      };

      footballMatch.IncreaseTeam1Score();
      footballMatch.IncreaseTeam1Score();
    }
  }
}