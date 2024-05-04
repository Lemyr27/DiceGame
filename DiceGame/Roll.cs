using System;

namespace DiceGame
{
    internal class Roll
    {
        public Tuple<Player, int> playerValue;

        public Roll(Player player)
        {
            int value = getDiceValue();
            playerValue = new Tuple<Player, int>(player, value);
        }

        private int getDiceValue()
        {
            Random rand = new Random();
            int maxValue = Dice.facets.Length + 1;
            return rand.Next(1, maxValue);
        }
    }
}
