using PouleSim.Utilities;

namespace PouleSim.Models
{
    public class Match
    {
        public Club HomeClub { get; set; }
        public Club AwayClub { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }

        public MatchResult MatchResult {
            get {
                if(HomeGoals > AwayGoals)
                {
                    return MatchResult.Home;
                }
                else if (HomeGoals < AwayGoals)
                {
                    return MatchResult.Away;
                }
                else
                {
                    return MatchResult.Draw;
                }
            }
        }

        public override string ToString()
        {
            return $"{HomeClub.Name} {HomeGoals} - {AwayGoals} {AwayClub.Name}";
        }

    }
}