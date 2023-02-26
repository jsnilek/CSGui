using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyGui
{
    public class AskPlayerEventArgs : EventArgs
    {
        public string MessageToAsk;
        public bool Answer;
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
            var arg = new AskPlayerEventArgs() { MessageToAsk = message };
            AskEvent(null, arg);
            return arg.Answer;
        }
        public static void FightEnemies(Player player, IEnumerable<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                Process(player, enemy);
            }
        }

        private static void Process(Player player, Enemy enemy)
        {
            var round = 0;

            while (true)
            {
                round++;
                OnAskEvent("continue to fight");
                FightRound(player, enemy);
                // DialogResult dialogResult = MessageBox.Show("Progress the fight", "Round" + counter, MessageBoxButtons.YesNo);
                if (player.Stamina <= 0) throw new Exception("you died");
                if (enemy.Stamina <= 0) return;
            }
        }
        private static void FightRound(Player player, Enemy enemy)
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
