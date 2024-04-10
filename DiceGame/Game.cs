using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Game
    {
        private List<Player> playersList;
        private List<Round> roundsList = new List<Round>();
        private int minNumToPass;

        public Game(int playersCount, int minNumToPass)
        {
            this.minNumToPass = minNumToPass;
            List<Player> players = new List<Player>();

            for (int i = 0; i < playersCount; i++)
            {
                players.Add(new Player());
            }
            // Начать раунд
        }

        public Round newRound()
        {
            // Прописать конструктор Раунда
            return new Round();
        }
    }
}
