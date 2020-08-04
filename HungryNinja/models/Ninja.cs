using System;
using System.Collections.Generic;

namespace HungryNinja
{
    abstract class Ninja
    {
        public List<IConsumable> FoodHistory { get; }

        public Ninja()
        {
            FoodHistory = new List<IConsumable>();
        }

        public abstract bool IsFull();

        public abstract void Eat(IConsumable item);
    }
}
