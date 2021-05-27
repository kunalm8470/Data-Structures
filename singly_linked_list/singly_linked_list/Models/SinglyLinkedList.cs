using singly_linked_list.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace singly_linked_list.Models
{
    public class SinglyLinkedList<T> : IEnumerable<Node<T>>, ISinglyLinkedList<T> where T : struct
    {
        #region Core implementation
        public SinglyLinkedList() { }

        public SinglyLinkedList(Node<T> head) 
        {
            _head = head;
        }

        private Node<T> _head;
        public Node<T> First
        {
            get
            {
                return _head;
            }
        }

        private Node<T> _tail;
        public Node<T> Last
        {
            get
            {
                return _tail;
            }
        }

        private int _length;
        public int Count
        {
            get
            {
                return _length;
            }
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> current = _head;
            while (current != default)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        public SinglyLinkedList<T> InsertRear(T data)
        {
            Node<T> newNode = new(data);

            if (_head == default)
            {
                _head = newNode;
            }
            else
            {
                // Before
                // 1 -> null

                // After
                // 1 -> 2 -> null
                _tail.Next = newNode;
            }

            _tail = newNode;
            _length++;
            return this;
        }

        public SinglyLinkedList<T> Delete(T data)
        {
            if (_head == default)
                return this;

            // If LL contains single node
            if (_head == _tail && _head.Data.Equals(data))
            {
                _head = default;
                _tail = default;
                _length--;
                return this;
            }

            Node<T> current = _head;
            Node<T> previous = default;
            while (current != default && !current.Data.Equals(data))
            {
                previous = current;
                current = current.Next;
            }

            // Element not found
            if (previous == default || current == default) return this;

            //Before
            // 1 -> 2 -> 3 -> 4 -> 5 -> null
            // if data = 3

            // After
            // current
            previous.Next = current.Next;
            current.Next = default;
            _length--;
            return this;
        }

        public Node<T> Reverse(Node<T> head)
        {
            if (head == default) return default;

            if (head.Next == default) return head;

            Node<T> current = head;
            Node<T> prev = default;
            Node<T> next = default;

            // null -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null
            while (current != default)
            {
                // Save next
                next = current.Next;

                // Reverse
                current.Next = prev;

                // Advance previous
                prev = current;

                // Advance current
                current = next;
            }

            return prev;
        }
    }
}
