using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Player
    {
        private static int currentId = 0;
        private static int currentChips = 0;
        private int id;
        private int chips;

        public Player()
        {
            currentId += 1;
            id = currentId;
            this.chips = currentChips;
        }
    }
}
