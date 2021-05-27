using System;

namespace binary_search_tree.Models
{
    /// <summary>
    /// POCO to represent the BST
    /// </summary>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; }
        public BinarySearchTree(Node<T> root)
        {
            Root = root;
        }

        public BinarySearchTree() { }
    }
}
