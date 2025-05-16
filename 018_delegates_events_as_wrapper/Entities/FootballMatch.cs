namespace Delegates
{
  public class FootballMatch
  {
    // We still need a delegate
    public delegate void GoalScoredHandler(string scoringTeam, int team1Score, int team2Score);

    // We decorate the delegate variable with the event keyword
    // This is the event that will be raised when a goal is scored
    // Event is better than a delegate because it is more secure
    // The event keyword restricts the access to the delegate
    // The event keyword makes it impossible to call the delegate directly
    // The event keyword makes it impossible to assign a new delegate to the delegate variable
    // The event keyword makes it impossible to remove the delegate from the event
    public event GoalScoredHandler GoalScored;

    public string Team1 { get; private set; }
    public string Team2 { get; private set; }

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

      // Inside the class that declared the event,
      // We have access to all public members of the delegate
      GoalScored?.Invoke(Team1, Team1Score, Team2Score);
    }

    public void IncreaseTeam2Score()
    {
      Team2Score++;
      GoalScored?.Invoke(Team2, Team1Score, Team2Score);
    }
  }
}