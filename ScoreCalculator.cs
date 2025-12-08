namespace Yahtzee
{
    // Contains static methods for scoring logic
    public static class ScoreCalculator
    {
        public static int ScoreForCategory(ScoreCategory category, int[] dice)
        {
            int[] counts = GetCounts(dice);
            switch (category)
            {
                case ScoreCategory.Ones: return counts[0] * 1;
                case ScoreCategory.Twos: return counts[1] * 2;
                case ScoreCategory.Threes: return counts[2] * 3;
                case ScoreCategory.Fours: return counts[3] * 4;
                case ScoreCategory.Fives: return counts[4] * 5;
                case ScoreCategory.Sixes: return counts[5] * 6;
                case ScoreCategory.ThreeOfAKind: return IsNOfAKind(counts, 3) ? Sum(dice) : 0;
                case ScoreCategory.FourOfAKind: return IsNOfAKind(counts, 4) ? Sum(dice) : 0;
                case ScoreCategory.FullHouse: return IsFullHouse(counts) ? 25 : 0;
                case ScoreCategory.SmallStraight: return IsSmallStraight(counts) ? 30 : 0;
                case ScoreCategory.LargeStraight: return IsLargeStraight(counts) ? 40 : 0;
                case ScoreCategory.Yahtzee: return IsNOfAKind(counts, 5) ? 50 : 0;
                case ScoreCategory.Chance: return Sum(dice);
                default: return 0;
            }
        }

        public static int[] GetCounts(int[] dice)
        {
            int[] counts = new int[6];
            foreach (var value in dice)
                counts[value - 1]++;
            return counts;
        }

        public static bool IsNOfAKind(int[] counts, int n)
        {
            foreach (var count in counts)
                if (count >= n) return true;
            return false;
        }

        public static bool IsFullHouse(int[] counts)
        {
            bool hasThree = false, hasTwo = false;
            foreach (var count in counts)
            {
                if (count == 3) hasThree = true;
                if (count == 2) hasTwo = true;
            }
            return hasThree && hasTwo;
        }

        public static bool IsSmallStraight(int[] counts)
        {
            // Check for any sequence of 4
            int[][] straights = { new[] { 0, 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4, 5 } };
            foreach (var straight in straights)
            {
                bool found = true;
                foreach (var idx in straight)
                    if (counts[idx] == 0) found = false;
                if (found) return true;
            }
            return false;
        }

        public static bool IsLargeStraight(int[] counts)
        {
            // Check for sequence of 5
            return (counts[0] == 1 && counts[1] == 1 && counts[2] == 1 && counts[3] == 1 && counts[4] == 1) ||
                   (counts[1] == 1 && counts[2] == 1 && counts[3] == 1 && counts[4] == 1 && counts[5] == 1);
        }

        public static int Sum(int[] dice)
        {
            int total = 0;
            foreach (var value in dice)
                total += value;
            return total;
        }
    }
}