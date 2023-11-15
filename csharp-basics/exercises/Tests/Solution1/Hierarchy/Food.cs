using System;

namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity { get; }

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}