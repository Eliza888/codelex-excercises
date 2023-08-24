using System;

namespace MakeSounds
{

    public class Firework : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Fireworks go whoosh-bang!");
        }
    }
}