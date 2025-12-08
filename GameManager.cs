using System;

namespace Yahtzee
{
    // Handles game logic and state transitions
    public class GameManager
    {
        public GameState State { get; set; }
        public Player CurrentPlayer => State.Players[State.CurrentPlayerIndex];
        public bool CanRoll => State.RollCount < 3;
        public bool CanEndTurn => State.RollCount > 0;

        public GameManager()
        {
            State = new GameState();
        }

        // Starts a new game
        public void StartNewGame()
        {
            State.Players.Clear();
            State.Players.Add(new Player("User", false));
            State.Players.Add(new Player("Computer", true)); // true = IsCom
            State.CurrentPlayerIndex = 0;
            State.RollCount = 0;
            State.DiceSet.ResetHolds();
            RollDice();
        }

        // Rolls the dice
        public void RollDice()
        {
            if (CanRoll)
            {
                State.DiceSet.Roll(new Random());
                State.RollCount++;
            }
        }

        // Toggles hold for a die
        public void ToggleHold(int dieIndex)
        {
            State.DiceSet.Held[dieIndex] = !State.DiceSet.Held[dieIndex];
        }

        // Assigns score for a category
        public void ScoreCategory(Player player, ScoreCategory category)
        {
            if (player.ScoreCard.GetScore(category) == null)
            {
                int score = ScoreCalculator.ScoreForCategory(category, State.DiceSet.Values);
                player.ScoreCard.AssignScore(category, score);
                State.RollCount = 0;
                State.DiceSet.ResetHolds();
            }
        }

        // Checks if a category can be scored
        public bool CanScore(ScoreCategory category)
        {
            return CurrentPlayer.ScoreCard.GetScore(category) == null && State.RollCount > 0;
        }

        // Moves to the next turn
        public void NextTurn()
        {
            State.CurrentPlayerIndex = (State.CurrentPlayerIndex + 1) % State.Players.Count;
            State.RollCount = 0;
            State.DiceSet.ResetHolds();
            RollDice();
        }
    }
}