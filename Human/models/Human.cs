using System;

namespace Human
{
    class Human
    {
        // Fields
        protected string _name;
        protected int _strength;
        protected int _intelligence;
        protected int _dexterity;
        protected int _health;
        protected int _max_health;

        // Properties
        public string Name
        {
            get { return _name; }
        }
        public int Strength
        {
            get { return _strength; }
        }
        public int Intelligence
        {
            get { return _intelligence; }
        }
        public int Dexterity
        {
            get { return _dexterity; }
        }
        public int Health
        {
            get { return _health; }
        }

        // Constructor
        public Human(string name, int str=3, int intel=3, int dex=3, int health=100)
        {
            if (name == "")
            {
                throw new System.ArgumentException("Parameter required", "name");
            }
            _name = name;
            _strength = str;
            _intelligence = intel;
            _dexterity = dex;
            _health = health;
            _max_health = health;
        }

        public virtual void Attack(Human target)
        {
            if (IsAlive())
            {
                int damage = _strength * 5;
                Console.WriteLine(
                    $"{Name} attacks {target.Name} and deals {damage} damage!");
                target.TakeDamage(damage);
            }
        }

        public void TakeDamage(int damage)
        {
            _health = (damage < _health) ? _health - damage : 0;
            IsAlive();
        }

        public int GainHealth(int health)
        {
            int healthGain = (health < _max_health) ? health : _max_health - health;
            _health += healthGain;
            return healthGain;
        }

        private bool IsAlive() {
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} is dead.");
                return false;
            }
            return true;
        }
    }
}
