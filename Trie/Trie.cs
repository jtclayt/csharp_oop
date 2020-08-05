using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    public class Trie
    {
        private TrieNode _root;
        private int _count;
        public int Count
        {
            get { return _count; }
        }

        public Trie()
        {
            _root = new TrieNode('/');
            _count = 0;
        }

        public void Add(string word)
        {
            TrieNode curr = _root;
            word = word.ToLower();
            foreach (var c in word)
            {
                int idx = getIndex(c);
                if (curr.Nexts[idx] == null)
                {
                    curr.Nexts[idx] = new TrieNode(c);
                }
                curr = curr.Nexts[idx];
            }
            curr.IsWord = true;
        }

        public bool Contains(string word)
        {
            TrieNode curr = _root;
            word = word.ToLower();
            foreach (var c in word)
            {
                int idx = getIndex(c);
                if (curr.Nexts[idx] != null)
                {
                    curr = curr.Nexts[idx];
                }
                else
                {
                    return false;
                }
            }
            return curr.IsWord;
        }

        public string[] Autocomplete(string prefix)
        {
            TrieNode curr = _root;
            prefix = prefix.ToLower();
            foreach (var c in prefix)
            {
                int idx = getIndex(c);
                if (curr.Nexts[idx] != null)
                {
                    curr = curr.Nexts[idx];
                }
                else
                {
                    return new string[0];
                }
            }
            return getWords(curr, prefix, new List<string>()).ToArray();
        }

        public void PrintTrie()
        {
            List<string> words = new List<string>();
            foreach (var node in _root.Nexts)
            {
                if (node != null)
                {
                    getWords(node, $"{node.Value}", words);
                }
            }
            Console.WriteLine("\nWords in the trie:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }

        private List<string> getWords(TrieNode node, string word, List<string> words)
        {
            foreach (var curr in node.Nexts)
            {
                if (curr != null)
                {
                    StringBuilder sb = new StringBuilder(word);
                    sb.Append(curr.Value);
                    if (curr.IsWord)
                    {
                        words.Add(sb.ToString());
                    }
                    getWords(curr, sb.ToString(), words);
                }
            }
            return words;
        }

        private int getIndex(char letter)
        {
            return letter - 97;
        }

        private class TrieNode
        {
            public char Value { get; }
            public bool IsWord { get; set; }
            public TrieNode[] Nexts { get; }

            public TrieNode(char value)
            {
                Value = value;
                IsWord = false;
                Nexts = new TrieNode[26];
            }
        }
    }
}