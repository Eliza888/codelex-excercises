using DragRace;
using System;

public class Lexus : ICar, INitrous
{
    private int _currentSpeed = 0;

    public void SpeedUp()
    {
        _currentSpeed += 12;
    }

    public void SlowDown()
    {
        _currentSpeed -= 12;
    }

    public string ShowCurrentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public void UseNitrousOxideEngine()
    {
        _currentSpeed += 20;
    }

    public void StartEngine()
    {
        Console.WriteLine("Rrrrrrr.....");
    }
}