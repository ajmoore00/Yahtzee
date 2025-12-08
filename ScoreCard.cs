using System.Collections.Generic;

namespace Yahtzee
{
    // Stores scores for each category
    public class ScoreCard
    {
        public Dictionary<ScoreCategory, int?> Scores { get; private set; }

        public ScoreCard()
        {
            Scores = new Dictionary<ScoreCategory, int?>();
            foreach (ScoreCategory cat in System.Enum.GetValues(typeof(ScoreCategory)))
                Scores[cat] = null;
        }

        // Assigns a score to a category
        public void AssignScore(ScoreCategory category, int score)
        {
            Scores[category] = score;
        }

        // Gets the score for a category
        public int? GetScore(ScoreCategory category)
        {
            return Scores[category];
        }

        // Gets the sum of upper section (Ones-Sixes)
        public int GetUpperSum()
        {
            int sum = 0;
            for (ScoreCategory cat = ScoreCategory.Ones; cat <= ScoreCategory.Sixes; cat++)
            {
                if (Scores[cat].HasValue)
                    sum += Scores[cat].Value;
            }
            return sum;
        }

        // Gets the total score
        public int GetTotal()
        {
            int total = 0;
            foreach (var score in Scores.Values)
            {
                if (score.HasValue)
                    total += score.Value;
            }
            // Add upper section bonus if needed
            if (GetUpperSum() >= 63)
                total += 35;
            return total;
        }
    }
}