using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SweetTooth st = new SweetTooth();
            SpiceHound sh = new SpiceHound();
            while (!st.IsFull())
            {
                st.Eat(buffet.Serve());
            }
            st.Eat(buffet.Serve());
            while (!sh.IsFull())
            {
                sh.Eat(buffet.Serve());
            }
            sh.Eat(buffet.Serve());
        }
    }
}
