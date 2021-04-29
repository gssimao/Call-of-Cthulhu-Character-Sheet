using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public interface IRandomizer
    {
        int RollingDices(int max);
    }

    public abstract class Randomizer : IRandomizer
    {
        // handles all of the Dice rolls
        public static readonly Random DiceRandom = new Random();
        public int RollingDices(int max)
        {
            int roll;
            roll = DiceRandom.Next(1, max);
            return roll;
        }
    }
}
