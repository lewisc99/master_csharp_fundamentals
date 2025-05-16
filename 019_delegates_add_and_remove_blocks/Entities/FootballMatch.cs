namespace Delegates
{
  public class FootballMatch
  {
    // We still need a delegate
    public delegate void GoalScoredHandler(string scoringTeam, int team1score, int team2score);

    // We decorate the delegate variable with the event keyword
    // This is the event that will be raised when a goal is scored
    // Event is better than a delegate because it is more secure
    // The event keyword restricts the access to the delegate
    // The event keyword makes it impossible to call the delegate directly
    // The event keyword makes it impossible to assign a new delegate to the delegate variable
    // The event keyword makes it impossible to remove the delegate from the event
    private event GoalScoredHandler _goalScored;
    public event GoalScoredHandler GoalScored
    {
      add
      {
        // Actions when subscriber registers
        _goalScored += value;
        Console.WriteLine($"GoalScored event has a new subscriber. Method added: {value.Method.Name}.");
      }
      remove
      {
        // Actions when subscriber removes itself
        _goalScored -= value;
        Console.WriteLine($"GoalScored event lost a subscriber. Method removed: {value.Method.Name}.");
      }
    }

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
      // GoalScored no longer can be used to invoke,
      // because it's only used for registering and removing subscribers
      _goalScored?.Invoke(Team1, Team1Score, Team2Score);
    }

    public void IncreaseTeam2Score()
    {
      Team2Score++;
      _goalScored?.Invoke(Team2, Team1Score, Team2Score);
    }
  }
}