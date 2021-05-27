using binary_search_tree.Models;
using System;

namespace binary_search_tree.Interfaces
{
    public interface IBinarySearchTree<T> where T : IComparable<T>
    {
        void InOrderTraversal(Node<T> node);
        void PreOrderTraversal(Node<T> node);
        void PostOrderTraversal(Node<T> node);
        Node<T> GenerateFrom(T[] arr, int left, int right);
        void PrintLeafNodes(Node<T> root);
        Node<T> Insert(Node<T> root, T data);
        bool Contains(Node<T> root, T key);
        int CalculateHeight(Node<T> root);
    }
}
