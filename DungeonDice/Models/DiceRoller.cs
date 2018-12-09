using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonDice.Models
{
    public class DiceRoller
    {
        public int rollResult = 0;

        public int D4Roll(out int rollResult)
        {
            Random rolld4 = new Random();
            rollResult = rolld4.Next(4);
        }
    }
}