using System;

namespace TreehouseDefenseGame
{
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        public ShieldedInvader(Path path) : base(path)
        {

        }
        public override void DecreaseHeath(int factor)
        {
            if (Random.NextDouble() < .5)
            {
                base.DecreaseHeath(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a shielded invader but it sustained no damage.");
            }
        }
    }
}
