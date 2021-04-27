using System;
using Xunit;
using PouleSim.Utilities;

namespace PouleSim.Tests
{
    public class MatchSimulator_GetWinChanceShould
    {
        [Theory]
        [InlineData(85,85,40,40)]
        [InlineData(90,85,40,45)]
        [InlineData(80,85,40,35)]
        [InlineData(100,60,40,80)]
        public void GetWinChance_InputShouldMatchResult( int yourPowerlevel, int opponentsPowerLevel, int baseWinChance, int expectedResult )
        {
            
            var result = MatchSimulator.GetWinChance(yourPowerlevel,opponentsPowerLevel,baseWinChance);
            Assert.Equal( expectedResult, result );
        }
    }

    public class MatchSimulator_DetermineWinnerGoalCapShould
    {
        [Theory]
        [InlineData(90, 70, 5)]
        [InlineData(80, 80, 3)]
        [InlineData(70, 90, 3)]
        [InlineData(100, 60, 7)]
        public void DetermineWinnerGoalCap_InputShouldMatchResult( int winnerPowerLevel, int loserPowerLevel, int expectedResult )
        {
            var result = MatchSimulator.DetermineWinnerGoalCap( winnerPowerLevel, loserPowerLevel );
            Assert.Equal( expectedResult, result );
        }
    }
}