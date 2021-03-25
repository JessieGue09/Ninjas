using System;

namespace Ninjas
{
    class Enemy
    {
        // Que tiene
        // (Igual que el player)
        public Health health;
        // Que acciones realiza
        // /(Igual que el player)

        public Enemy()
        {
            // 20 de vida, tienes maximo 20, comienzas con 20 de vida
            this.health = new Health(40, 40, 40);
        }
    }
}