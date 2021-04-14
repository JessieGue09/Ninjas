using System;

namespace Ninjas
{
    // Que tiene -> Atributos (Programación orientada a objetos)
    // - colisión (*)
    // - vida / health

    // Que hace -> Metodos (Programación orientada a objetos)
    // > acciones / verbos
    // - Movimiento -> Moverse() / Move()
    // - ataque -> Atacar() / Atack()

    class Player
    {
        // Atributos
        public Health health;
        public Movement movement;
        public int attackDamage = 30;


        public Player()
        {
            // 100 de vida, tienes maximo 100, comienzas con 100 de vida
            this.health = new Health(100, 100, 100);
        }



        // Metodos 
        public void Move()
        {

        }

        /// <summary>
        /// Attacjs a target
        /// </summary>
        /// <param name="target">True if attack was a succes</param>
        /// <returns></returns>
        public bool Attack(Health target)
        {
            if (target == null)
            {
                return false;
            }

            if (target.IsDead())
            {
                return false;
            }

            target.TakeDamage(attackDamage);

            return true;
        }

    }


}

