using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Roll
    {
        private Tuple<Player, int> playerValue;

        public Roll(Player player, int value)
        {
            playerValue = new Tuple<Player, int>(player, value);
        }
    }
}
