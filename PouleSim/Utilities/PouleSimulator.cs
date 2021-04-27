using System;
using PouleSim.Models;

namespace PouleSim.Utilities
{
    public static class PouleSimulator
    {
        public static PouleScore SimulatePoule(Poule poule)
        {
            int amountOfClubs = poule.Clubs.Count;

            // For each club, simulate matches with all clubs below them on the list.
            for (int i = 0; i < amountOfClubs; i ++ )
            {
                for (int j = i + 1; j < amountOfClubs; j ++ )
                {
                    Match simulatedMatch = MatchSimulator.SimulateMatch(poule.Clubs[i],poule.Clubs[j]);
                    Console.WriteLine($"Match simulated: {simulatedMatch.HomeClub.Name} vs. {simulatedMatch.AwayClub.Name}, Final score is: {simulatedMatch.HomeGoals}-{simulatedMatch.AwayGoals}");
                    poule.Matches.Add(simulatedMatch);
                }
            } 

            // Convert the data of the matches to the poulescore
            var matches = poule.Matches;
            // Return the Poulscore

            return ConvertPouleToScore(poule);
        }

        public static PouleScore ConvertPouleToScore(Poule poule)
        {
            PouleScore result = new PouleScore();

            foreach(Club c in poule.Clubs)
            {
                result.PouleScoreRows.Add(new PouleScoreRow(c));
            }

            foreach(Match m in poule.Matches)
            {
                ApplyMatchToPouleScore( m, result );
            }

            result.PouleScoreRows.Sort();

            return result;
        }

        private static void ApplyMatchToPouleScore(Match match, PouleScore score)
        {
            var homeClubScoreRow = score.PouleScoreRows.Find( i => object.ReferenceEquals(i.Club , match.HomeClub ));
            var awayClubScoreRow = score.PouleScoreRows.Find( i => object.ReferenceEquals(i.Club, match.AwayClub ));

            homeClubScoreRow.GoalsFor += match.HomeGoals;
            homeClubScoreRow.GoalsAgainst += match.AwayGoals;

            awayClubScoreRow.GoalsAgainst += match.HomeGoals;
            awayClubScoreRow.GoalsFor += match.AwayGoals;
            
            if( match.MatchResult == MatchResult.Home )
            {
                homeClubScoreRow.GamesWon++;
                awayClubScoreRow.GamesLost++;
            }
            else if ( match.MatchResult == MatchResult.Away )
            {
                awayClubScoreRow.GamesWon++;
                homeClubScoreRow.GamesLost++;
            }
            else 
            {
                homeClubScoreRow.GamesDrawn++;
                awayClubScoreRow.GamesDrawn++;
            }            
        }

    }
}