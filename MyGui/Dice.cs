using System;

namespace MyGui
{
    public static class Dice
    {
        private static readonly Random _rand = new Random(0);

        public static int Roll()
        {
            return _rand.Next(1, 6);
        }
        public static int DoubleRoll()
        {
            return Roll() + Roll();
        }
    }
}
