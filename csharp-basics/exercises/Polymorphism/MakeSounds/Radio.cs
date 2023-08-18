using MakeSounds;
using System;
using System.Collections.Generic;
using System.Text;

class Radio : ISound
{
    private string station;

    public Radio(string station)
    {
        this.station = station;
    }

    public void PlaySound()
    {
        Console.WriteLine($"The radio is playing some bangers!");
    }
}