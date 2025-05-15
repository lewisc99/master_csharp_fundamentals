namespace Delegates.Entities.V2
{
  public class FootballMatch
  {

    // Subscribe will use methods that match this delegate to subscribe
    public delegate void NotifyAboutGoals(string scoringTeam, int team1Score, int team2Score);

    // Subscribe will add themselves to this invocation list
    // we added this event to the class, because we want to notify
    // all subscribers when a goal is scored
    public NotifyAboutGoals NotifyOnGoalScored;

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

      // We are now just calling the delegate
      NotifyOnGoalScored?.Invoke(Team1, Team1Score, Team2Score);
      // We have put notification instructions directly inside the method
    }

    public void IncreaseTeam2Score()
    {
      Team2Score++;
      // We have put notification instructions directly inside the method
      NotifyOnGoalScored?.Invoke(Team2, Team1Score, Team2Score);
    }

  }
}