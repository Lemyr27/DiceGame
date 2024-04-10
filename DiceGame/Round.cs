using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Round
    {
        private static int currentRound = 0;

        private Player currentPlayer;
        private int bankOfChips;
        private List<Roll> rollsList;
    }
}
