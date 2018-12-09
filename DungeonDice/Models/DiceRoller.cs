using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonDice.Models
{
    public class Dice
    {
        private Random rand = new Random();
        private int sidesCount;

        public Dice()
        {
            sidesCount = 20;
        }

        public Dice(int sidesCount)
        {
            this.sidesCount = sidesCount;
        }

        public int GetSidesCount()
        {
            return sidesCount;
        }

        public int Roll()
        {
            return rand.Next(1, sidesCount + 1);
        }

        public override string ToString()
        {
            return String.Format("Rolling a {0}-sided die", sidesCount);
        }
    }
}