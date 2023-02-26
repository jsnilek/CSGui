using MyGui;
using NUnit.Framework;

namespace TestMyGui
{
    public class TestFight
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FightEnemy_NoEnemies()
        {
            var player = Player.GenerateNewPlayer(Player.PlayerClass.Warrior);
            FightEnemy.FightEnemies(player, null);
        }
    }
}