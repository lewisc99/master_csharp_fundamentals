namespace Delegates
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var footballMatch = new FootballMatch("Barcelona", "Real Madrid");

      footballMatch.GoalScored += (sender, eventArgs) =>
        {
          Console.WriteLine($"{eventArgs.Scorer} scored!");
          Console.WriteLine($"Score is {eventArgs.Team1Score}:{eventArgs.Team2Score}.");
        };

      footballMatch.IncreaseTeam1Score();
      footballMatch.IncreaseTeam2Score();
      footballMatch.IncreaseTeam1Score();
    }
  }
}
