using System;
using System.Text;

namespace DLList
{
    public class DLList
    {
        private DLNode _head;
        private DLNode _tail;
        private int _length;
        public int Length {
            get { return _length; }
        }

        public DLList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        public void Add(int value)
        {
            if (_length == 0)
            {
                _head = new DLNode(value);
                _tail = _head;
            }
            else {
                _tail.Next = new DLNode(value, _tail);
                _tail = _tail.Next;
            }
            _length++;
        }

        public bool Remove(int value)
        {
            if (_length == 0)
            {
                return false;
            }
            DLNode runner = _head;
            while (runner != null)
            {
                if (runner.Value == value)
                {
                    if (_head == runner)
                    {
                        _head = (runner.Next != null) ? runner.Next : null;
                    }
                    if (_tail == runner)
                    {
                        _tail = (runner.Prev != null) ? runner.Prev : null;
                    }
                    if (runner.Prev != null)
                    {
                        runner.Prev.Next = runner.Next;
                    }
                    if (runner.Next != null)
                    {
                        runner.Next.Prev = runner.Prev;
                    }
                    _length--;
                    return true;
                }
                runner = runner.Next;
            }
            return false;
        }

        public void Reverse()
        {
            DLNode runner = _head;
            while (runner.Next != null)
            {
                runner = runner.Next;
                runner.Prev.Next = runner.Prev.Prev;
                runner.Prev.Prev = runner;
            }
            runner.Next = runner.Prev;
            runner.Prev = null;
            _tail = _head;
            _head = runner;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            DLNode runner = _head;
            if (runner == null){
                return "List is empty...";
            }
            sb.Append($"Length: {Length} | <- ");
            while (runner.Next != null)
            {
                sb.Append($"{runner.Value} <-> ");
                runner = runner.Next;
            }
            sb.Append($"{runner.Value} ->");
            return sb.ToString();
        }

        private class DLNode
        {
            public int Value { get; set; }
            public DLNode Next { get; set; }
            public DLNode Prev { get; set; }

            public DLNode(int value, DLNode prev=null, DLNode next=null)
            {
                Value = value;
                Next = next;
                Prev = prev;
            }

            public override string ToString()
            {
                return $"{Value}";
            }
        }
    }
}