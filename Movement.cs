using System;

namespace Ninjas
{
    class Movement
    {
        public float speed;

        // teclas
        public float runspeed;
        public float walkspedd;
        //public float crouchpeed;
        
        // - power up
        // - debuff
        // - run
        // - crouch
        public void Move()
        {

        }
        
        public void Run()
        {
            this.speed = this.runspeed;
        }

        public void StopRunning()
        {
            this.speed = this.walkspedd;
        }
    }
}