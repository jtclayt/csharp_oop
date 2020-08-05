using System;

namespace DLList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLList list = new DLList();
            Console.WriteLine(list);
            Console.WriteLine($"Remove 3 from empty list: {list.Remove(3)}");
            list.Add(4);
            Console.WriteLine(list);
            list.Add(5);
            Console.WriteLine(list);
            Console.WriteLine($"Remove 5 from list: {list.Remove(5)}");
            Console.WriteLine(list);
            Console.WriteLine($"Remove 4 from list: {list.Remove(4)}");
            list.Add(3);
            list.Add(6);
            list.Add(1);
            list.Add(10);
            Console.WriteLine(list);
            Console.WriteLine($"Remove 6 from list: {list.Remove(6)}");
            Console.WriteLine($"Remove 4 from list: {list.Remove(4)}");
            list.Add(7);
            Console.WriteLine(list);
            list.Reverse();
            Console.WriteLine(list);
        }
    }
}
