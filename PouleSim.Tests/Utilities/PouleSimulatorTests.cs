using PouleSim.Models;
using Xunit;
using PouleSim.Utilities;
using System.Collections.Generic;

namespace PouleSim.Tests
{
    public class PouleSimulator_ConvertPouleToScoreShould
    {
        private static Club testclub1 = new Club {
            Name = "Testclub 1",
            Powerlevel = 60
        };

        private static Club testClub2 = new Club {
            Name = "Testclub 2",
            Powerlevel = 70
        };

        Match testMatch1 = new Match {
            HomeClub = testclub1,
            AwayClub = testClub2,
            HomeGoals = 3,
            AwayGoals = 2
        };

        [Fact]
        public void ConvertPouleToScore_OneClubShouldReturnNoMatchesPlayed()
        {
            //Arrange
            List<Club> clubs = new List<Club>() { testclub1 };
            Poule poule = new Poule( clubs );

            //Act
            PouleScore result = PouleSimulator.SimulatePoule(poule);

            //Assert
            Assert.Equal( result.PouleScoreRows[0].MatchesPlayed, 0 );
        }


        [Fact]
        public void ConvertPouleToScore_PouleWithoutMatchesShouldReturnZeroSheet()
        {
            //Arrange
            List<Club> clubs = new List<Club> { testclub1, testClub2 };
            Poule poule  = new Poule ( clubs );

            //Act
            PouleScore result = PouleSimulator.ConvertPouleToScore(poule);
            PouleScoreRow expectedResult = new PouleScoreRow(testclub1);

            //Assert
            Assert.Equal( expectedResult , result.PouleScoreRows[0] );
        }
    }
}