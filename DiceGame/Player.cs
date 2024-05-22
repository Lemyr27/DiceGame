using System.Linq;

namespace DiceGame
{
    internal class Player
    {
        private static int currentId = 0;

        public int id;
        public int chips;

        public Player(int chipsForOnePlayer)
        {
            id = ++currentId;
            chips = chipsForOnePlayer;
        }

        public Roll rollDice()
        {
            return new Roll(this);
        }

        public Player makePass(Game game)
        {
            Round round = game.roundsList.Last();
            int index = game.playersList.IndexOf(this);
            Player newPlayer = game.playersList[index + 1];
            round.currentPlayer = newPlayer;
            return newPlayer;
        }
    }
}
