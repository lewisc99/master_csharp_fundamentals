namespace Delegates.Entities.V1
{
  public class FootballMatch
  {
    public string Team1 { get; set; }
    public string Team2 { get; set; }

    public int Team1Score { get; private set; }
    public int Team2Score { get; private set; }

    public FootballMatch(string team1, string team2)
    {
      Team1 = team1;
      Team2 = team2;
    }
    public void IncreaseTeam1Score()
    {
      Team1Score++;
      // We have put notification instructions directly inside the method
      Console.WriteLine($"{Team1} scored. Current score is {Team1Score}:{Team2Score}.");
    }

    public void IncreaseTeam2Score()
    {
      Team2Score++;
      // We have put notification instructions directly inside the method
      Console.WriteLine($"{Team2} scored. Current score is {Team1Score}:{Team2Score}.");
    }

  }
}