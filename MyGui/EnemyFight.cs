using System;
using System.Windows.Forms;

namespace MyGui
{
    public class AskPlayerEventArgs : EventArgs
    {
        public string MessageToCombatLog;
        public bool TryLuck;
    }

    public static class FightEnemy
    {
        public static event EventHandler<CombatLogEventArgs> FightEvent = delegate { };
        public static event EventHandler<AskPlayerEventArgs> AskEvent = delegate { };

        static void OnFightEvent(string message)
        {
            FightEvent(null, new CombatLogEventArgs() { MessageToCombatLog = message });
        }

        static bool OnAskEvent(string message)
        {
            var arg = new AskPlayerEventArgs() { MessageToCombatLog = message };
            AskEvent(null, arg);
            return arg.TryLuck;
        }

        public enum FightResult
        {
            PlayerWon,
            EnemyWon,
            NoEnemy
        }

        public static FightResult Process(Player player, Enemy enemy)
        {
            if (enemy == null) return FightResult.NoEnemy;

            var counter = 0;

            while (true)
            {
                counter++;
                FightRound(player, enemy);
                // DialogResult dialogResult = MessageBox.Show("Progress the fight", "Round" + counter, MessageBoxButtons.YesNo);
                if (player.Stamina <= 0) return FightResult.EnemyWon;
                if (enemy.Stamina <= 0) return FightResult.PlayerWon;
            }
        }
        public static void FightRound(Player player, Enemy enemy)
        {
            var enemyAP = Dice.DoubleRoll() + enemy.AP;
            var playerAP = Dice.DoubleRoll() + player.Ap;
            if (playerAP > enemyAP)
            {
                YouSuccessed(player, enemy, enemyAP, playerAP);
            }
            else if (playerAP == enemyAP)
            {
                HitParried(enemy, enemyAP, playerAP);
            }
            else
            {
                EnemySuccessed(player, enemy, enemyAP, playerAP);
            }

        }

        private static void EnemySuccessed(Player player, Enemy enemy, int enemyAP, int playerAP)
        {
            OnFightEvent($"{enemy.Name}s {enemyAP} ap is higher than yours AP {playerAP} ");
            OnFightEvent($"{enemy.Name} striked for 2");
            player.Stamina -= 2;
            if (OnAskEvent("do you want to try luck for extra 1 damage"))
                player.TryLuck();
        }

        private static void HitParried(Enemy enemy, int enemyAP, int playerAP)
        {
            OnFightEvent($"Your parry {enemy.Name}s {enemyAP} AP ");
            OnFightEvent($"You striked {enemy.Name} for 2");
        }

        private static void YouSuccessed(Player player, Enemy enemy, int enemyAP, int playerAP)
        {
            OnFightEvent($"Your {playerAP} ap is higher than {enemy.Name}s {enemyAP} AP ");
            OnFightEvent($"You striked {enemy.Name} for 2");
            enemy.Stamina -= 2;
            if (OnAskEvent("do you want to try luck to lower 1 damage"))
                player.TryLuck();
        }
    }
}
