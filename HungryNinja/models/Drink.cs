using System;

namespace HungryNinja
{
    class Drink : IConsumable
    {
        public string Name { get; }
        public int Calories { get; }
        public bool IsSpicy { get; }
        public bool IsSweet { get; }

        public Drink(string name, int calories)
        {
            Name = name;
            Calories = calories;
            IsSpicy = false;
            IsSweet = true;
        }

        public string GetInfo()
        {
            return $"{Name} (Drink) Calories: {Calories}. It\'s sweet!";
        }
    }
}
