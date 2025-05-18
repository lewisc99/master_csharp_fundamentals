namespace Delegates
{
  // We created a separate class
  // that will hold data to be passed
  // to subscribers
  public class GoalScoredArgs
  {
    public string Scorer { get; set; }
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }

    public GoalScoredArgs(string scorer, int team1Score, int team2Score)
    {
      Scorer = scorer;
      Team1Score = team1Score;
      Team2Score = team2Score;
    }
  }
}