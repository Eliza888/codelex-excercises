using MakeSounds;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

class Parrot : ISound
{
    private string name;

    public Parrot(string name)
    {
        this.name = name;
    }

    public void PlaySound()
    {
        Console.WriteLine($"Parrot {name}: Screeech!");
    }
}