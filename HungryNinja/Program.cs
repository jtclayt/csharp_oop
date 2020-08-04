using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            List<Ninja> ninjas = new List<Ninja>();
            ninjas.Add(new SweetTooth());
            ninjas.Add(new SweetTooth());
            ninjas.Add(new SpiceHound());

            foreach (var ninja in ninjas)
            {
                while (!ninja.IsFull())
                {
                    ninja.Eat(buffet.Serve());
                }
                ninja.Eat(buffet.Serve());
                Console.WriteLine("-------------------------------------------------------------");
            }

            PrintStats(ninjas);
        }

        public static void PrintStats(List<Ninja> ninjas)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            int totalConsumed = 0;
            string topFood = null;
            int topCount = 0;
            string secFood = null;
            int secCount = 0;

            foreach (var ninja in ninjas)
            {
                totalConsumed += ninja.FoodHistory.Count;
                foreach (var food in ninja.FoodHistory)
                {
                    if (counts.ContainsKey(food.Name))
                    {
                        counts[food.Name]++;
                    }
                    else{
                        counts.Add(food.Name, 1);
                    }
                }
            }

            foreach (var item in counts)
            {
                if (item.Value > topCount)
                {
                    if (topFood != null)
                    {
                        secFood = topFood;
                        secCount = topCount;
                    }
                    topFood = item.Key;
                    topCount = item.Value;
                }
                else if (item.Value > secCount)
                {
                    secFood = item.Key;
                    secCount =  item.Value;
                }
            }
            Console.WriteLine($"Ninjas ate a total of {totalConsumed} items.");
            Console.WriteLine($"Most eaten item was {topFood} consumed {topCount} times.");
            Console.WriteLine($"Next most eaten item was {secFood} consumed {secCount} times.");
        }
    }
}
