using System;
using System.Text;

namespace SLList
{
    public class SLList
    {
        private SLNode _head;
        private int _length;
        public int Length {
            get { return _length; }
        }

        public SLList()
        {
            _head = null;
            _length = 0;
        }

        public void Add(int value)
        {
            if (_head == null)
            {
                _head = new SLNode(value);
            }
            else
            {
                SLNode runner = _head;
                while (runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = new SLNode(value);
            }
            _length++;
        }

        public int Remove()
        {
            int value;
            if (_head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            else if (_head.Next == null)
            {
                value = _head.Value;
                _head = null;
            }
            else
            {
                SLNode runner = _head;
                while (runner.Next.Next != null)
                {
                    runner = runner.Next;
                }
                value = runner.Next.Value;
                runner.Next = null;
            }
            _length--;
            return value;
        }

        public int RemoveAt(int index)
        {
            int value;

            if (index < 0 || index >= _length)
            {
                throw new IndexOutOfRangeException("Index not in list.");
            }
            else if (index == _length - 1)
            {
                return this.Remove();
            }
            else if (index == 0)
            {
                value = _head.Value;
                _head = _head.Next;
            }
            else
            {
                SLNode runner = _head;
                while (index != 1)
                {
                    runner = runner.Next;
                    index--;
                }
                value = runner.Next.Value;
                runner.Next = runner.Next.Next;
            }
            _length--;
            return value;
        }

        public int Find(int val)
        {
            int index = 0;
            if (_head != null)
            {
                SLNode runner = _head;
                while (runner != null)
                {
                    if (runner.Value == val)
                    {
                        return index;
                    }
                    index++;
                    runner = runner.Next;
                }
            }
            return -1;
        }

        public void PrintList()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            SLNode runner = _head;
            while (runner != null)
            {
                sb.Append($"{runner} -> ");
                runner = runner.Next;
            }
            return sb.ToString();
        }

        private class SLNode {
            public int Value { get; set; }
            public SLNode Next { get; set; }

            public SLNode(int value, SLNode next=null)
            {
                Value = value;
                Next = next;
            }

            public override string ToString()
            {
                return $"{Value}";
            }
        }
    }
}