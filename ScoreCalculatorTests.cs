using System;
using System.Diagnostics;

namespace Yahtzee
{
    // Simple unit tests for ScoreCalculator
    public static class ScoreCalculatorTests
    {
        public static void RunAllTests()
        {
            Debug.Assert(ScoreCalculator.ScoreForCategory(ScoreCategory.FullHouse, new[] { 2, 2, 3, 3, 3 }) == 25);
            Debug.Assert(ScoreCalculator.ScoreForCategory(ScoreCategory.Yahtzee, new[] { 6, 6, 6, 6, 6 }) == 50);
            Debug.Assert(ScoreCalculator.ScoreForCategory(ScoreCategory.SmallStraight, new[] { 1, 2, 3, 4, 6 }) == 30);
            Debug.Assert(ScoreCalculator.ScoreForCategory(ScoreCategory.LargeStraight, new[] { 2, 3, 4, 5, 6 }) == 40);
            Debug.Assert(ScoreCalculator.ScoreForCategory(ScoreCategory.ThreeOfAKind, new[] { 4, 4, 4, 2, 5 }) == 19);
            Debug.Assert(ScoreCalculator.ScoreForCategory(ScoreCategory.Chance, new[] { 1, 2, 3, 4, 5 }) == 15);
            // Add more tests as needed
        }
    }
}