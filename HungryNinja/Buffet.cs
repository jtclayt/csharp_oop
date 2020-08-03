using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
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
    }

    class Buffet
    {
        public List<Food> Menu { get; }

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Sushi", 300, false, false),
                new Food("Chicken Tenders", 800, false, false),
                new Food("Hot Wings", 500, true, false),
                new Food("Curry", 400, true, false),
                new Food("Pizza", 900, false, false),
                new Food("Ice Cream", 450, false, true),
                new Food("Tamarind Candy", 200, true, true)
            };
        }

        public Food Serve()
        {
            Random rng = new Random();
            int idx = rng.Next(Menu.Count);
            return Menu[idx];
        }
    }

    class Ninja
    {
        private int _calorieIntake;
        public List<Food> FoodHistory { get; }

        public Ninja()
        {
            _calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull()
        {
            return _calorieIntake > 1200;
        }

        public void Eat(Food item)
        {
            string output;
            if (!this.IsFull())
            {
                output = $"Ninja ate {item.Name}";
                if (item.IsSpicy)
                {
                    output += " (Spicy)";
                }
                if (item.IsSweet)
                {
                    output += " (Sweet)";
                }
                _calorieIntake += item.Calories;
                FoodHistory.Add(item);
            }
            else{
                output = "Ninja is too full to eat!";
            }
            Console.WriteLine(output);
        }
    }
}
