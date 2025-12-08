using System;

namespace Yahtzee
{
    // Represents the set of dice for the game
    public class DiceSet
    {
        public int[] Values { get; private set; } = new int[5];
        public bool[] Held { get; private set; } = new bool[5];

        // Rolls all unheld dice
        public void Roll(Random rng)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if (!Held[i])
                    Values[i] = rng.Next(1, 7); // Dice values 1-6
            }
        }

        // Resets all holds
        public void ResetHolds()
        {
            for (int i = 0; i < Held.Length; i++)
                Held[i] = false;
        }

        // Returns counts of each face (1-6)
        public int[] GetCounts()
        {
            int[] counts = new int[6];
            foreach (var value in Values)
                counts[value - 1]++;
            return counts;
        }

        // Returns sum of all dice
        public int Sum()
        {
            int total = 0;
            foreach (var value in Values)
                total += value;
            return total;
        }
    }
}