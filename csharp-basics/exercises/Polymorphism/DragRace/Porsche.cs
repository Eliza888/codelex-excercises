using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Porsche : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 15;
        }

        public void SlowDown()
        {
            _currentSpeed -= 15;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Roarrr...");
        }
    }
}
