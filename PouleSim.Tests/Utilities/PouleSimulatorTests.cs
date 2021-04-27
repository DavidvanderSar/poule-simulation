using PouleSim.Models;
using Xunit;
using PouleSim.Utilities;
using System.Collections.Generic;

namespace PouleSim.Tests
{
    public class PouleSimulator_ConvertPouleToScoreShould
    {
        private static Club testClub1 = new Club {
            Name = "Testclub 1",
            Powerlevel = 60
        };

        private static Club testClub2 = new Club {
            Name = "Testclub 2",
            Powerlevel = 70
        };

         private static Club testClub3 = new Club {
            Name = "Testclub 3",
            Powerlevel = 80
        };

         private static Club testClub4 = new Club {
            Name = "Testclub 4",
            Powerlevel = 75
        };

         private static Club testClub5 = new Club {
            Name = "Testclub 5",
            Powerlevel = 65
        };

         private static Club testClub6 = new Club {
            Name = "Testclub 6",
            Powerlevel = 50
        };

        Match testMatch1 = new Match {
            HomeClub = testClub1,
            AwayClub = testClub2,
            HomeGoals = 2,
            AwayGoals = 1
        };

        Match testMatch2 = new Match {
            HomeClub = testClub1,
            AwayClub = testClub3,
            HomeGoals = 5,
            AwayGoals = 3
        };

        Match testMatch3 = new Match {
            HomeClub = testClub1,
            AwayClub = testClub4,
            HomeGoals = 5,
            AwayGoals = 3
        };

        Match testMatch4 = new Match {
            HomeClub = testClub1,
            AwayClub = testClub5,
            HomeGoals = 2,
            AwayGoals = 0
        };

        Match testMatch5 = new Match {
            HomeClub = testClub1,
            AwayClub = testClub6,
            HomeGoals = 2,
            AwayGoals = 0
        };

        Match testMatch6 = new Match {
            HomeClub = testClub2,
            AwayClub = testClub3,
            HomeGoals = 0,
            AwayGoals = 1
        };

        Match testMatch7 = new Match {
            HomeClub = testClub2,
            AwayClub = testClub4,
            HomeGoals = 0,
            AwayGoals = 1
        };

        Match testMatch8 = new Match {
            HomeClub = testClub2,
            AwayClub = testClub5,
            HomeGoals = 1,
            AwayGoals = 0
        };

        Match testMatch9 = new Match {
            HomeClub = testClub2,
            AwayClub = testClub6,
            HomeGoals = 1,
            AwayGoals = 0
        };

        Match testMatch10 = new Match {
            HomeClub = testClub3,
            AwayClub = testClub4,
            HomeGoals = 1,
            AwayGoals = 0
        };

        Match testMatch11 = new Match {
            HomeClub = testClub3,
            AwayClub = testClub5,
            HomeGoals = 0,
            AwayGoals = 1
        };

        Match testMatch12 = new Match {
            HomeClub = testClub3,
            AwayClub = testClub6,
            HomeGoals = 0,
            AwayGoals = 1
        };

        Match testMatch13 = new Match {
            HomeClub = testClub4,
            AwayClub = testClub5,
            HomeGoals = 1,
            AwayGoals = 0
        };

        Match testMatch14 = new Match {
            HomeClub = testClub4,
            AwayClub = testClub6,
            HomeGoals = 0,
            AwayGoals = 1
        };

        Match testMatch15 = new Match {
            HomeClub = testClub5,
            AwayClub = testClub6,
            HomeGoals = 1,
            AwayGoals = 0
        };

        [Fact]
        public void ConvertPouleToScore_OneClubShouldReturnNoMatchesPlayed()
        {
            //Arrange
            List<Club> clubs = new List<Club>() { testClub1 };
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
            List<Club> clubs = new List<Club> { testClub1, testClub2 };
            Poule poule  = new Poule ( clubs );

            //Act
            PouleScore result = PouleSimulator.ConvertPouleToScore(poule);
            PouleScoreRow expectedResult = new PouleScoreRow(testClub1);

            //Assert
            Assert.Equal( expectedResult , result.PouleScoreRows[0] );
        }

        [Fact]
        public void ConvertPouleToScore_PouleShouldOrderDrawsInCorrectOrder()
        {
            //Arrange
            List<Club> clubs = new List<Club> { testClub1, testClub2, testClub3, testClub4, testClub5, testClub6 };
            List<Match> matches = new List<Match> { testMatch1, testMatch2, testMatch3, testMatch4, testMatch5, 
                testMatch6, testMatch7, testMatch8, testMatch9, testMatch10, testMatch11, 
                testMatch12, testMatch13, testMatch14, testMatch15 }; 
            Poule poule = new Poule() {
                Clubs = clubs,
                Matches = matches
            };
            
            //Act                                               
            PouleScore result = PouleSimulator.ConvertPouleToScore( poule );

            //Assert
            Assert.Equal( testClub1, result.PouleScoreRows[0].Club );
            Assert.Equal( testClub2, result.PouleScoreRows[1].Club );
            Assert.Equal( testClub3, result.PouleScoreRows[2].Club );
            Assert.Equal( testClub4, result.PouleScoreRows[3].Club );
            Assert.Equal( testClub5, result.PouleScoreRows[4].Club );
            Assert.Equal( testClub6, result.PouleScoreRows[5].Club );
        }
    }
}