using System;

namespace Human
{
    class Samurai : Human
    {

        // Constructor
        public Samurai(string name, int str=6, int intel=3, int dex=4, int health=200) : base(
            name, str, intel, dex, health)
        {

        }

        public override void Attack(Human target)
        {
            if (target.Health <= 50)
            {
                int damage = 50;
                Console.WriteLine(
                    $"{Name} executes {target.Name} dealing {damage} damage!");
                target.TakeDamage(damage);
            }
            else
            {
                base.Attack(target);
            }
        }

        public void Meditate()
        {
            Console.WriteLine($"{Name} meditated and healed to full health.");
            _health = _max_health;
        }
    }
}
