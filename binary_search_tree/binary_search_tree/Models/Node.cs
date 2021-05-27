using System;

namespace binary_search_tree.Models
{
    public class Node<T> : IComparable<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T item)
        {
            this.Data = item;
        }

        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }
    }
}
