using System;
using System.Collections.Generic;

namespace PouleSim.Models
{
    public class PouleScore
    {
        public List<PouleScoreRow> PouleScoreRows { get; set; }

        public PouleScore()
        {
            PouleScoreRows = new List<PouleScoreRow>();
        }
    }

    public class PouleScoreRow : IComparable<PouleScoreRow>
    {
        public PouleScoreRow(Club club)
        {
            Club = club;
            GamesWon = 0;
            GamesDrawn = 0;
            GamesLost = 0;
            GoalsFor = 0;
            GoalsAgainst = 0;
        }

        public Club Club { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public int GamesDrawn { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }

        public int GoalsAggregate { 
            get {
                return GoalsFor - GoalsAgainst;
            }
        }
        public int MatchesPlayed {
            get {
                return ( GamesWon + GamesDrawn + GamesLost );
            }
        }
        public int Points {
            get {
                return ( 3 * GamesWon + 1 * GamesDrawn );
            }
        }
        public override string ToString()
        {
            return $"{Club.Name} ({Club.Powerlevel}) | {MatchesPlayed} | {GamesWon} | {GamesDrawn} | {GamesLost} | {GoalsFor} | {GoalsAgainst} | {Points}";
        }

        public int CompareTo(PouleScoreRow other)
        {
            //1. Sort based on scored points.
            int result = other.Points.CompareTo(this.Points);
            //2. Sort based on Goals Aggregate.
            if ( result == 0 )
            {
                result = other.GoalsAggregate.CompareTo(this.GoalsAggregate);
            }
            //3. Sort based on Goals For.
            if( result == 0 )
            {
                result = other.GoalsFor.CompareTo(this.GoalsFor);
            }
            //4. Sort based on Goals Against.
            if( result == 0 )
            {
                result = other.GoalsAgainst.CompareTo(this.GoalsAgainst);
            }
            //5. Sort based on their match result.
            //TODO: Implement match comparison.

            return result;
        }
    }
}