using System;

namespace Human
{
    class Wizard : Human
    {

        // Constructor
        public Wizard(string name, int str=3, int intel=15, int dex=3, int health=50) : base(
            name, str, intel, dex, health)
        {

        }

        public override void Attack(Human target)
        {
            int damage = _intelligence * 5;
            int healthGained = GainHealth(damage);
            Console.WriteLine(
                $"{Name} casts a spell at {target.Name}, deals {damage} damage, and heals {damage} health!");
            target.TakeDamage(damage);
        }

        public void Heal(Human target)
        {
            int health = _intelligence*10;
            int healthGained = target.GainHealth(health);
            Console.WriteLine($"{Name} heals {target.Name} for {healthGained} health.");
        }
    }
}
