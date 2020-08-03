using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human me = new Human("Justin", 4, 5, 2, 120);
            Human other = new Human("Other");
            me.Attack(other);
        }
    }


    class Human
    {
        // Fields
        private string _name;
        private int _strength;
        private int _intelligence;
        private int _dexterity;
        private int _health;

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
        }

        public void Attack(Human target)
        {
            int damage = this._strength * 5;
            target._health -= damage;
            Console.WriteLine(
                $"{this._name} attacks {target._name} and deals {damage} damage!");
        }
    }
}
