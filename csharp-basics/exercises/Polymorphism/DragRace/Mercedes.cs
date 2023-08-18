using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Mercedes : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 10;
        }

        public void SlowDown()
        {
            _currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Vroom Vroom...");
        }
    }
}
