using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human me = new Human("Justin", 4, 5, 2, 120);
            Wizard wizard = new Wizard("Wizard");
            Ninja ninja = new Ninja("Ninja");
            Samurai samurai = new Samurai("Samurai");
            me.Attack(wizard);
            wizard.Attack(me);
            wizard.Heal(me);
            ninja.Attack(me);
            ninja.Steal(me);
            samurai.Attack(me);
            samurai.Attack(me);
            wizard.Heal(me);
            me.Attack(ninja);
            me.Attack(samurai);
            samurai.Meditate();
            samurai.Attack(ninja);
            samurai.Attack(ninja);
            samurai.Attack(ninja);
            samurai.Attack(ninja);
        }
    }
}
