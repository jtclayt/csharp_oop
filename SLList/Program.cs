using System;

namespace SLList
{
    class Program
    {
        static void Main(string[] args)
        {
            SLList list = new SLList();
            Console.WriteLine($"List: {list}");
            Console.WriteLine($"Length: {list.Length}");
            try
            {
                list.Remove();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            list.Add(1);
            Console.WriteLine($"Value removed: {list.Remove()}");
            list.Add(4);
            list.Add(5);
            Console.WriteLine($"Value removed: {list.Remove()}");
            Console.WriteLine($"List: {list}");
            Console.WriteLine($"Length: {list.Length}");
            Console.WriteLine($"Value removed: {list.RemoveAt(0)}");
            list.Add(4);
            list.Add(5);
            Console.WriteLine($"Value removed: {list.RemoveAt(0)}");
            list.Add(9);
            list.Add(2);
            list.Add(1);
            list.Add(5);
            Console.WriteLine($"Index of 9: {list.Find(9)}");
            Console.WriteLine($"Value removed: {list.RemoveAt(3)}");
            list.PrintList();
            try
            {
                list.RemoveAt(9);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
