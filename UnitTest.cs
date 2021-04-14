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

            // Atacar a la nada 
            bool succes = player.Attack(null);
            Assert.That(succes, Is.EqualTo(false));

            // Enemigo comienza con 40 de vida
            Assert.That(enemy.health.health, Is.EqualTo(40));
            Assert.That(enemy.health.IsAlive, Is.EqualTo(true));

            // Atacar al anemigo nos resta vida
            succes = player.Attack(enemy.health);
            Assert.That(succes, Is.EqualTo(true));
            Assert.That(enemy.health.health, Is.EqualTo(10));
            Assert.That(enemy.health.IsAlive, Is.EqualTo(true));

            // Atacar al enemigo nos resta vida
            succes = player.Attack(enemy.health);
            Assert.That(succes, Is.EqualTo(true));
            Assert.That(enemy.health.health, Is.EqualTo(0));
            Assert.That(enemy.health.IsAlive, Is.EqualTo(false));

            // Al atacar al anemigo con 0 de vida, el ataque es falso
            succes = player.Attack(enemy.health);
            Assert.That(succes, Is.EqualTo(false));
        }

        [Test, Description("Player attack a balloon")]
        public void TestPlayerAttackBalloon()
        { 
            Player player = new Player();
            Balloon balloon = new Balloon();

            // Is live
            Assert.That(balloon.health.health, Is.EqualTo(1));
            Assert.That(balloon.health.IsAlive(), Is.EqualTo(true));

            // Attack balloon
            bool success = player.Attack(balloon.health);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(balloon.health.health, Is.EqualTo(0));
            Assert.That(balloon.health.IsAlive(), Is.EqualTo(false));

        }

        [Test, Description("Player can defeat a barrel")]
        public void TestPlayerDefeatBarrel()
        {
            Player player = new Player();
            Barrel barrel = new Barrel();

            // Is live
            Assert.That(barrel.health.health, Is.EqualTo(200));
            Assert.That(barrel.health.IsAlive(), Is.EqualTo(true));

            // Attack barrel
            bool success = player.Attack(barrel.health);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(barrel.health.health, Is.EqualTo(170));
            Assert.That(barrel.health.IsAlive(), Is.EqualTo(true));

            player.Attack(barrel.health);
            player.Attack(barrel.health);
            player.Attack(barrel.health);
            player.Attack(barrel.health);
            player.Attack(barrel.health);
            player.Attack(barrel.health);

            Assert.That(barrel.health.health, Is.EqualTo(0));
            Assert.That(barrel.health.IsAlive(), Is.EqualTo(false));
        }
    }
}