using System;
using System.Collections.Generic;

namespace Education.Core.DataStuctures
{
    public class PriorityQueue<TKey, TValue> where TKey : IComparable
    {
        private readonly LinkedList<KeyValuePair<TKey, TValue>> _queue;

        public PriorityQueue()
        {
            _queue = new LinkedList<KeyValuePair<TKey, TValue>>();
        }

        public void Insert(KeyValuePair<TKey, TValue> pair)
        {
            if (_queue.Count == 0)
            {
                _queue.AddFirst(pair);
                return;
            }

            var node = _queue.First;
            
            while (pair.Key.CompareTo(node.Value.Key) > 0 && node.Next != null)
            {
                node = node.Next;
            }

            if (pair.Key.CompareTo(node.Value.Key) >= 0)
            {
                _queue.AddAfter(node, pair);
            }
            else
            {
                _queue.AddBefore(node, pair);
            }
        }

        public bool TryExtractMaximum(out KeyValuePair<TKey, TValue> pair)
        {
            if (_queue.Count == 0)
            {
                pair = default(KeyValuePair<TKey, TValue>);
                return false;
            }

            pair = _queue.Last.Value;
            _queue.RemoveLast();
            return true;
        }

        public bool TryExtractMinimum(out KeyValuePair<TKey, TValue> pair)
        {
            if (_queue.Count == 0)
            {
                pair = default(KeyValuePair<TKey, TValue>);
                return false;
            }

            pair = _queue.First.Value;
            _queue.RemoveFirst();
            return true;
        }
    }
}
