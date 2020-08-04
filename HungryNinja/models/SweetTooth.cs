using System;

namespace HungryNinja
{
    class SweetTooth : Ninja
    {
        private int _calorieIntake;

        public SweetTooth() : base()
        {
            _calorieIntake = 0;
        }

        public override bool IsFull()
        {
            return _calorieIntake >= 1500;
        }

        public override void Eat(IConsumable item)
        {
            string output;
            if (!this.IsFull())
            {
                output = $"Sweet tooth ate {item.GetInfo()}";
                _calorieIntake += item.Calories;
                if (item.IsSweet)
                {
                    _calorieIntake += 10;
                }
                FoodHistory.Add(item);
            }
            else{
                output = "Sweet tooth is too full to eat!";
            }
            Console.WriteLine(output);
        }
    }
}
