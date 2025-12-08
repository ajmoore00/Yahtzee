namespace Yahtzee
{
    // Simple computer logic for computer player
    public static class ComEngine
    {
        // Decides which dice to hold (greedy: hold most common face)
        public static bool[] DecideHolds(int[] dice, int roll, ScoreCard scoreCard)
        {
            int[] counts = ScoreCalculator.GetCounts(dice);
            int maxCount = 0, maxFace = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > maxCount)
                {
                    maxCount = counts[i];
                    maxFace = i + 1;
                }
            }
            bool[] holds = new bool[5];
            for (int i = 0; i < dice.Length; i++)
                holds[i] = dice[i] == maxFace;
            return holds;
        }

        // Chooses the best category to score (highest possible score)
        public static ScoreCategory ChooseCategory(int[] dice, ScoreCard scoreCard)
        {
            int bestScore = -1;
            ScoreCategory bestCat = ScoreCategory.Chance;
            foreach (ScoreCategory cat in System.Enum.GetValues(typeof(ScoreCategory)))
            {
                if (scoreCard.GetScore(cat) == null)
                {
                    int score = ScoreCalculator.ScoreForCategory(cat, dice);
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestCat = cat;
                    }
                }
            }
            return bestCat;
        }
    }
}