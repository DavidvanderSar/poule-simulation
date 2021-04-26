using System;
using PouleSim.Models;

namespace PouleSim.Utilities
{
    public enum MatchResult { Home, Away, Draw };

    public static class MatchSimulator
    {
         private const int BASIC_WIN_CHANCE = 40; // chance in percentage
         private const int MIN_GOAL_CAP = 3; // minimum cap of amount of goals that the winner scores more than the opponent

         private static MatchResult SimulateMatchWinner(int HomePowerLevel, int AwayPowerLevel)
         {
             int homeWinChance = GetWinChance( HomePowerLevel, AwayPowerLevel );
             int awayWinChance = GetWinChance( AwayPowerLevel, HomePowerLevel );

             Random rng = new Random();
             
             var result = rng.Next(1,101);

             if( result <= homeWinChance )
             {
                 return MatchResult.Home;
             }
             if( result > ( 100 - awayWinChance ))
             {
                return MatchResult.Away;
             }
             
             return MatchResult.Draw;
         }

        
         public static int GetWinChance(int yourPowerlevel, int opponentsPowerlevel, int baseWinChance = BASIC_WIN_CHANCE)
         {
            return baseWinChance + ( yourPowerlevel - opponentsPowerlevel );
         }

         public static ( int goalsHome, int goalsAway ) SimulateScoredGoals( int HomePowerLevel, int AwayPowerLevel, MatchResult result ) 
         {
            Random rng = new Random();

            int baseGoals = rng.Next(0,3);
            int powerDifference = HomePowerLevel - AwayPowerLevel;
            //Case : Game ended in a draw 
            switch( result )
            {
                case MatchResult.Draw:
                {
                    return ( baseGoals, baseGoals );
                }
                case MatchResult.Home:
                {
                    int goalCap = 3 + Math.Max(0, powerDifference / 10 );
                    return ( baseGoals + rng.Next(1,goalCap), baseGoals );
                }
                case MatchResult.Away:
                {
                    int goalCap = 3 + Math.Max( 0, (-1 * powerDifference) / 10 );
                    return ( baseGoals , baseGoals + rng.Next(1,goalCap));
                }

                default:
                {
                    //TODO: Throw error
                    return (baseGoals, baseGoals);
                }

            }
         }

         public static int DetermineWinnerGoalCap( int winnerPowerLevel, int loserPowerLevel )
         {
             int powerDifference = winnerPowerLevel - loserPowerLevel;
             return MIN_GOAL_CAP + Math.Max(0,powerDifference / 10); 
         }

         public static Match SimulateMatch(Club homeClub, Club awayClub)
         {
            MatchResult winner = SimulateMatchWinner( homeClub.Powerlevel, awayClub.Powerlevel );
            var ( homeGoals, awayGoals ) = SimulateScoredGoals(homeClub.Powerlevel, awayClub.Powerlevel, winner );
            return new Match
            {
                HomeClub = homeClub,
                AwayClub = awayClub,
                HomeGoals = homeGoals,
                AwayGoals = awayGoals
            };
         }


    }
}