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
        public void FightEnemy_NoEnemy()
        {
            var player = Player.GenerateNewPlayer(Player.PlayerClass.Warrior);
            FightEnemy.Process(player, null);
        }

        [Test]
        public void FightEnemy_PlayerWin()
        {
            var player = Player.GenerateNewPlayer(Player.PlayerClass.Warrior);
            Assert.AreEqual(FightEnemy.Process(player, null), FightEnemy.FightResult.NoEnemy);
        }
    }
}