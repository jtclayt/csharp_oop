using System;

namespace HungryNinja
{
    class Food : IConsumable
    {
        public string Name { get; }
        public int Calories { get; }
        public bool IsSpicy { get; }
        public bool IsSweet { get; }

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }

        public string GetInfo()
        {
            return $"{Name} (Food) Calories: {Calories}.  Spicy? {IsSpicy} Sweet? {IsSweet}";
        }
    }
}
