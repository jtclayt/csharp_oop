using System;

namespace Human
{
    class Ninja : Human
    {

        // Constructor
        public Ninja(string name, int str=5, int intel=3, int dex=10, int health=100) : base(
            name, str, intel, dex, health)
        {

        }

        public override void Attack(Human target)
        {
            Random rng = new Random();
            int damage = 5 * _dexterity;
            damage = (rng.Next(1,6) == 5) ? damage + 10 : damage;
            Console.WriteLine(
                $"{Name} slices at {target.Name} and deals {damage} damage!");
            target.TakeDamage(damage);
        }

        public void Steal(Human target)
        {
            int damage = 5;
            int healthGained = GainHealth(damage);
            Console.WriteLine(
                $"{Name} steals from {target.Name}, deals {damage} damage, and heals {damage} health!");
            target.TakeDamage(damage);
        }
    }
}
