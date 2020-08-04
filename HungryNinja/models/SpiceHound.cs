using System;

namespace HungryNinja
{
    class SpiceHound : Ninja
    {
        private int _calorieIntake;

        public SpiceHound() : base()
        {
            _calorieIntake = 0;
        }

        public override bool IsFull()
        {
            return _calorieIntake >= 1200;
        }

        public override void Eat(IConsumable item)
        {
            string output;
            if (!this.IsFull())
            {
                output = $"Spice hound ate {item.GetInfo()}";
                _calorieIntake += item.Calories;
                if (item.IsSweet)
                {
                    _calorieIntake -= 5;
                }
                FoodHistory.Add(item);
            }
            else{
                output = "Spice hound is too full to eat!";
            }
            Console.WriteLine(output);
        }
    }
}
