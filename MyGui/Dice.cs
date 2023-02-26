using System;

namespace MyGui
{
    public static class Dice
    {
        private static readonly Random _rand = new Random(0);

        public  static int Roll()
        {                                                                   
             var diceThrow =_rand.Next(1, 6);
            MainWindow.DisplayInLogin(diceThrow);
            return diceThrow;
        }
        public static int DoubleRoll()
        {
            return Roll() + Roll();
        }
    }
}
