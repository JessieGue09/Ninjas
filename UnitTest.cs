using System;
using NUnit.Framework;

namespace Ninjas
{
    class UnitTest
    {
        [Test, Description("Player can defeat an enemy")]
        public void TestPlayerDefeatEnemy()
        {
            Player player = new Player();
            Enemy enemy = new Enemy();

            bool succes = player.Attack(null);
            Assert.That(succes, Is.EqualTo(false));

            Assert.That(enemy.health.health, Is.EqualTo(40));
            Assert.That(enemy.health.IsAlive, Is.EqualTo(true));
            succes = player.Attack(enemy);
            Assert.That(succes, Is.EqualTo(true));

            Assert.That(enemy.health.health, Is.EqualTo(10));
            Assert.That(enemy.health.IsAlive, Is.EqualTo(true));
            succes = player.Attack(enemy);
            Assert.That(succes, Is.EqualTo(true));

            Assert.That(enemy.health.health, Is.EqualTo(0));
            Assert.That(enemy.health.IsAlive, Is.EqualTo(false));

            succes = player.Attack(enemy);
            Assert.That(succes, Is.EqualTo(false));
        }
    }
}