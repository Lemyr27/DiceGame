using System;
using System.Collections.Generic;

namespace DiceGame
{
    static class Dice
    {
        private static readonly List<int> facets = new List<int>() { 1, 2, 3, 4, 5, 6 };

        public static int RollDice()
        {
            Random random = new Random();
            int index = random.Next(1, facets.Count);
            return facets[index];
        }
    }
}
