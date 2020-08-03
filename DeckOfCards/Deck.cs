using System;
using System.Text;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Card
    {
        private int _value;
        public string Suit { get; }
        public string Val { get; }

        public Card(int value, string suit, string val)
        {
            this._value = value;
            this.Suit = suit;
            this.Val = val;
        }

        public override string ToString()
        {
            return $"{this.Val} of {this.Suit}";
        }
    }

    class Deck
    {
        private List<Card> _cards;

        public Deck()
        {
            this.Reset();
            this.Shuffle();
        }

        public void Reset()
        {
            this._cards = new List<Card>();
            for (int i = 0; i < 52; i++)
            {
                _cards.Add(new Card(i, getSuit(i), getVal(i)));
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int numTimes = rng.Next(3, 6) * _cards.Count;
            for (int i = 0; i < numTimes; i++)
            {
                int idx = i % 52;
                int randIdx = rng.Next(_cards.Count);
                Card temp = _cards[idx];
                _cards[idx] = _cards[randIdx];
                _cards[randIdx] = temp;
            }
        }

        public Card Deal()
        {
            if (this.IsEmpty())
            {
                throw new IndexOutOfRangeException("Deck is empty.");
            }
            Card top = _cards[0];
            _cards.RemoveAt(0);
            return top;
        }

        public bool IsEmpty()
        {
            return _cards.Count == 0;
        }

        private static string getSuit(int num)
        {
            string[] suits = new string[] {"Clubs", "Spades", "Diamonds", "Hearts"};
            return suits[num / 13];
        }

        private static string getVal(int num)
        {
            string[] vals = new string[] {"Ace", "2", "3", "4", "5", "6",
                "7", "8", "9", "10", "Jack", "Queen", "King"};
            return vals[num % 13];
        }
    }

    class Player
    {
        private List<Card> _cards;
        public string Name { get; }

        public Player(string name)
        {
            this.Name = name;
            this._cards = new List<Card>();
        }

        public void Draw(Deck deck)
        {
            if (!deck.IsEmpty())
            {
                this._cards.Add(deck.Deal());
            }
            else
            {
                Console.WriteLine("Deck is empty!");
            }
        }

        public Card Discard(int index)
        {
            if (index >= 0 && index < this._cards.Count)
            {
                Card card = this._cards[index];
                this._cards.RemoveAt(index);
                return card;
            }
            return null;
        }

        public void PrintHand()
        {
            Console.WriteLine($"{this.Name}\'s Hand");
            for (int i = 0; i < _cards.Count; i++)
            {
                Console.WriteLine($"Card {i+1}: {this._cards[i]}");
            }
            Console.WriteLine();
        }
    }
}
