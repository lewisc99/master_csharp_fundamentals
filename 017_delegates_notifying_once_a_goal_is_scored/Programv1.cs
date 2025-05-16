using Delegates.Entities.V1;

namespace Delegates.program
{
    class Program
    {
        static void MainV1(string[] args)
        {
            var footballMatch = new FootballMatch("Barcelona", "Real Madrid");

            footballMatch.IncreaseTeam1Score();
            footballMatch.IncreaseTeam2Score();
            footballMatch.IncreaseTeam1Score();
        }
    }
}