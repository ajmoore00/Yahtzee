using System.Collections.Generic;

namespace Yahtzee
{
    // Stores the overall game state
    public class GameState
    {
        public List<Player> Players { get; set; }
        public int CurrentPlayerIndex { get; set; }
        public int RollCount { get; set; }
        public DiceSet DiceSet { get; set; }

        public GameState()
        {
            Players = new List<Player>();
            DiceSet = new DiceSet();
            CurrentPlayerIndex = 0;
            RollCount = 0;
        }
    }
}