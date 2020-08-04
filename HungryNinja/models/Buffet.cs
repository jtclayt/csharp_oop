using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<IConsumable> Menu { get; }

        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Sushi", 200, false, false),
                new Food("Chicken Tenders", 400, false, false),
                new Food("Hot Wings", 250, true, false),
                new Food("Curry", 100, true, false),
                new Food("Pizza", 350, false, false),
                new Food("Ice Cream", 400, false, true),
                new Food("Tamarind Candy", 25, true, true),
                new Drink("Soda", 100),
                new Drink("Orange Juice", 80),
                new Drink("Water", 0),
                new Drink("Coffee", 5),
                new Drink("Horchata", 50)
            };
        }

        public IConsumable Serve()
        {
            Random rng = new Random();
            int idx = rng.Next(Menu.Count);
            return Menu[idx];
        }
    }
}
