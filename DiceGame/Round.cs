using System.Collections.Generic;

namespace DiceGame
{
    internal class Round
    {
        private static int currentId = 0;

        public int roundNumber;
        public Player currentPlayer;
        public int bankOfChips = 0;
        public List<Roll> rollsList = new List<Roll> { };

        public Round(Player currentPlayer)
        {
            roundNumber = ++currentId;
            this.currentPlayer = currentPlayer;
        }

        public int paymentPerRound(Player player)
        {
            if (player.chips <= 0) 
                return -1;
            player.chips--;
            bankOfChips++;
            return 1;
        }
    }
}
