using Delegates.Entities.V2;

namespace Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      var footballMatch = new FootballMatch("Barcelona", "Real Madrid");

      // We add our method to the invocation list.
      // Whenever a goal is scored, this method will now be invoked.
      // We can add additional methods too, depending on how we want to be notified
      footballMatch.NotifyOnGoalScored += (scorer, team1Score, team2Score) =>
      {
        Console.WriteLine($"{scorer} scored. Current score is {team1Score}:{team2Score}.");
      };

      footballMatch.IncreaseTeam1Score();
      footballMatch.IncreaseTeam1Score();
    }
  }
}