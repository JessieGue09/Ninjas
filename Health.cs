using System;

namespace Ninjas
{
    class Health
    {

        public int health;
        public int maxHealth;
        public int initialHealth;

        // max 200
        // 100/200

        public Health(int health, int maxHealth, int initialHealth)
        {
            this.health = health;
            this.maxHealth = maxHealth;
            this.initialHealth = initialHealth;
        }

        public void TakeDamage(int damage)
        {
            // if (damage > this.health)
            // {
            //     this.health = 0;
            // } 
            // else 
            // {
            //     this.health = this.health - damage;
            // }

            this.health = this.health - damage;

            if (this.health < 0)
            {
                this.health = 0;
            }

            // if (this.IsDead())
            // {
            //     this.health = 0;
            // }
        }

        public bool IsAlive()
        {
            // TODO: implemet using this.health
            if (this.health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDead()
        {
            return !this.IsAlive();
        }
    }
}