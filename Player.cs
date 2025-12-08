namespace Yahtzee
{
    // Represents a player in the game
    public class Player
    {
        public string Name { get; set; }
        public bool IsCom { get; set; } // Was IsAI
        public ScoreCard ScoreCard { get; set; }

        public Player(string name, bool isCom)
        {
            Name = name;
            IsCom = isCom;
            ScoreCard = new ScoreCard();
        }

        // Computes the total score for the player
        public int ComputeTotal()
        {
            return ScoreCard.GetTotal();
        }
    }
}