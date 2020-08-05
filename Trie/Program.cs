using System;
using System.Text;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.PrintTrie();
            PopulateTrie(trie);
            trie.PrintTrie();
            TestContains(trie);
            TestAutocomplete(trie);
        }

        public static void PopulateTrie(Trie trie)
        {
            trie.Add("hello");
            trie.Add("high");
            trie.Add("green");
        }

        public static void TestContains(Trie trie)
        {
            Console.WriteLine("Test contains method:");
            Console.WriteLine($"Boop in trie: {trie.Contains("boop")}");
            Console.WriteLine($"Hello in trie: {trie.Contains("Hello")}");
            Console.WriteLine();
        }

        public static void TestAutocomplete(Trie trie)
        {
            Console.WriteLine("Test autocomplete method:");
            string[] possibleWords = trie.Autocomplete("h");
            Console.WriteLine("Possible words for \"h\":");
            PrintStrings(possibleWords);
            Console.WriteLine();
            possibleWords = trie.Autocomplete("");
            Console.WriteLine("Possible words for \"\":");
            PrintStrings(possibleWords);
            Console.WriteLine();
            possibleWords = trie.Autocomplete("boo");
            Console.WriteLine("Possible words for \"boo\":");
            PrintStrings(possibleWords);
            Console.WriteLine();
        }

        public static void PrintStrings(string[] strings)
        {
            StringBuilder sb = new StringBuilder("[");
            foreach (var str in strings)
            {
                sb.Append($"{str}, ");
            }
            if (sb.Length > 1)
            {
                sb.Remove(sb.Length - 2, 1);
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }
}
