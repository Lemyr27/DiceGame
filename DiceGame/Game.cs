using System.Collections.Generic;
using System.Linq;

namespace DiceGame
{
    internal class Game
    {
        public List<Player> playersList = new List<Player>();
        public List<Round> roundsList = new List<Round>();
        public int minNumToPass;

        public Game(int numberOfPlayers, int chipsForOnePlayer, int minNumToPass)
        {
            this.minNumToPass = minNumToPass;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                playersList.Add(new Player(chipsForOnePlayer));
            }
        }

        public Round createRound(Player currentPlayer)
        {
            Round round = new Round(currentPlayer);
            roundsList.Add(round);
            return round;
        }
    }
}
