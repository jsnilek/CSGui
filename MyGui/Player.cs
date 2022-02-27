using System;

namespace MyGui
{
    public class CombatLogEventArgs : EventArgs
    {
        public string MessageToCombatLog;
    }
    public class Player
    {
        public PlayerClass pclass;
        public bool Alive = true;
        public int MaxAp;
        public int MaxStamina;
        public int MaxLuck;
        public int Ap;
        public int Stamina;
        public int Luck;
        public int Coins = 10;
        public int Proviant = 2;

        public static event EventHandler<CombatLogEventArgs> StatsGenerated = delegate { };
        static void OnStatsGenerated(string message)
        {
            StatsGenerated(null, new CombatLogEventArgs() { MessageToCombatLog = message });
        }

        private Player(int ap, int stamina, int luck, PlayerClass playerclass)
        {
            OnStatsGenerated($"You start \n with {ap} AP");
            OnStatsGenerated($"You start with {stamina} stamina");
            OnStatsGenerated($"You start with {luck} luck");
            MaxAp = ap;
            MaxStamina = stamina;
            MaxLuck = luck;
            pclass = playerclass;
            Ap = ap;
            Stamina = stamina;
            Luck = luck;
        }

        public enum PlayerClass
        {
            Mage,
            Warrior
        }

        public static Player GenerateNewPlayer(PlayerClass role)
        {
            var ApBonus = role == PlayerClass.Warrior ? 6 : 4;
            return new Player(
                Dice.Roll() + ApBonus,
                Dice.DoubleRoll() + 12,
                Dice.Roll() + 6, role);
        }

        public bool TryLuck()
        {
            var lucky = Dice.Roll() > Luck;
            Luck--;
            return lucky;
        }
    }
}
