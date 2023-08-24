using MakeSounds;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<ISound> soundableObjects = new List<ISound>
        {
            new Parrot("Jeeves Beaker"),
            new Parrot("Delta Chatter"),
            new Radio("FM 104.3"),
            new Radio("AM 720"),
            new Firework(),
            new Firework()
        };

        foreach (var obj in soundableObjects)
        {
            obj.PlaySound();
        }
    }
}